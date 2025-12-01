using LibreHardwareMonitor.Hardware;
using SimpleHWInfo.LoadingView;
using SimpleHWInfo.Provider;

namespace SimpleHWInfo.HW_FullMonitor
{
    public class HwFullMonitor_Presenter
    {
        private readonly HwFullMonitor_View _view;

        // 센서 Identifier → ListViewItem
        private readonly Dictionary<string, ListViewItem> _dic_sensorItem =
            new Dictionary<string, ListViewItem>();

        private bool _isInitialized;

        public HwFullMonitor_Presenter(HwFullMonitor_View view)
        {
            _view = view;
        }

        public async Task LoadingStart_async()
        {
            using ( var tLoading = new Loading_View() )
            {
                tLoading.StartPosition = FormStartPosition.CenterParent;
                tLoading.Show(_view);
                tLoading.Refresh();

                HardwareRawSnapshot_model tSnap;

                try
                {
                    tSnap = await Task.Run(() =>
                    {
                        return HardwareMonitorProvider.Instance.GetRawSnapshot();
                    });
                }
                catch ( Exception ex )
                {
                    tLoading.Close();

                    MessageBox.Show
                    (
                        _view ,
                        "하드웨어 정보를 불러오는 중 오류가 발생했습니다.\r\n" + ex.Message ,
                        "오류" ,
                        MessageBoxButtons.OK ,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                tLoading.Close();
                _view.RefreshTimer.Start();
            }
        }

        public async Task RefreshSensor_async()
        {
            HardwareRawSnapshot_model tSnap = await Task.Run(() =>
            {
                return HardwareMonitorProvider.Instance.GetRawSnapshot();
            });

            ListView tListView = _view.HardWareListView;

            if ( tListView.IsDisposed )
            {
                return;
            }

            if ( tListView.InvokeRequired )
            {
                tListView.BeginInvoke(new Action(() =>
                {
                    ApplySnapShot(tListView , tSnap);
                }));
            }
            else
            {
                ApplySnapShot(tListView , tSnap);
            }
        }

        private void ApplySnapShot(ListView listView, HardwareRawSnapshot_model snap)
        {
            if(!_isInitialized)
            {
                InitListViewStruct(listView , snap);
                _isInitialized = true;
            }
            else
            {
                UpdateListView(snap);
            }
        }

        // 그룹 / 아이템 구조 생성
        private void InitListViewStruct(ListView listView, HardwareRawSnapshot_model snap)
        {
            listView.BeginUpdate();

            listView.Items.Clear();
            listView.Groups.Clear();

            _dic_sensorItem.Clear();

            foreach ( var tHw in snap.list_Hardwares )
            {
                string tGroupHeader = $"[{tHw.HardwareType}] {tHw.Name}";
                var tGroup = new ListViewGroup(tGroupHeader);
                listView.Groups.Add(tGroup);

                AddHardwareGroupItem(listView , tGroup , tHw , 0);
            }

            listView.EndUpdate();
        }

        private void AddHardwareGroupItem(ListView listView, ListViewGroup group, HardwareNode_model hwNode, int indentLevel)
        {
            string tIndent = new string('\u00A0', indentLevel * 4);

            // (옵션) 루트가 아닌 경우, 하위 하드웨어 이름을 헤더 행으로 한 번 찍어줌
            if ( indentLevel > 0 )
            {
                var tHeaderItem = new ListViewItem($"{tIndent}{hwNode.Name}");
                tHeaderItem.Group = group;
                tHeaderItem.Font = new Font(listView.Font , FontStyle.Bold);
                // 값/Min/Max는 비워둔 헤더 역할
                tHeaderItem.SubItems.Add(string.Empty);
                tHeaderItem.SubItems.Add(string.Empty);
                tHeaderItem.SubItems.Add(string.Empty);

                listView.Items.Add(tHeaderItem);
            }

            // 실제 센서들
            foreach ( var tSensor in hwNode.list_Sensors )
            {
                string tSensorName = $"{tIndent}{GetSensorDisplayName(tSensor)}";

                string tValueStr = FormatSensorValue(tSensor, tSensor.Value);
                string tMaxStr = FormatSensorValue(tSensor, tSensor.Max);
                string tMinStr = FormatSensorValue(tSensor, tSensor.Min);

                var tItem = new ListViewItem(tSensorName);
                tItem.Group = group;
                tItem.SubItems.Add(tValueStr); // Value
                tItem.SubItems.Add(tMaxStr);   // Max
                tItem.SubItems.Add(tMinStr);   // Min

                listView.Items.Add(tItem);

                // Identifier가 있는 센서만 딕셔너리에 매핑
                if ( !string.IsNullOrEmpty(tSensor.Identifier) &&
                     !_dic_sensorItem.ContainsKey(tSensor.Identifier) )
                {
                    _dic_sensorItem.Add(tSensor.Identifier , tItem);
                }
            }

            // 하위 하드웨어는 같은 그룹에 들여쓰기만 +1 해서 재귀
            foreach ( var tSub in hwNode.list_SubHardwares )
            {
                AddHardwareGroupItem(listView , group , tSub , indentLevel + 1);
            }
        }

        // 값 갱신 
        private void UpdateListView(HardwareRawSnapshot_model snap)
        {
            foreach ( var tHw in snap.list_Hardwares )
            {
                UpdateListViewValue(tHw);
            }
        }

        private void UpdateListViewValue(HardwareNode_model hwNode)
        {
            foreach ( var tSensor in hwNode.list_Sensors )
            {
                if ( string.IsNullOrEmpty(tSensor.Identifier) )
                {
                    continue;
                }

                if ( !_dic_sensorItem.TryGetValue(tSensor.Identifier , out var tItem) )
                {
                    // 새 센서가 생겼다면 여기서 새 아이템 추가 로직을 넣어도 됨.
                    continue;
                }

                string tValueStr = FormatSensorValue(tSensor ,tSensor.Value);
                string tMaxStr = FormatSensorValue(tSensor ,tSensor.Max);
                string tMinStr = FormatSensorValue(tSensor ,tSensor.Min);

                if ( tItem.SubItems.Count >= 4 )
                {
                    tItem.SubItems[ 1 ].Text = tValueStr;
                    tItem.SubItems[ 2 ].Text = tMaxStr;
                    tItem.SubItems[ 3 ].Text = tMinStr;
                }
            }

            foreach ( var tSub in hwNode.list_SubHardwares )
            {
                UpdateListViewValue(tSub);
            }
        }

        private string GetSensorDisplayName(Sensor_model sensor)
        {
            string tSuffix = sensor.SensorType switch
            {
                SensorType.Load        => " -usage",
                SensorType.Temperature => " -temp",
                SensorType.Power       => " -power",
                SensorType.Clock       => " -clock",
                SensorType.Voltage     => " -volt",
                SensorType.Fan         => " -fan",
                _                      => string.Empty
            };

            return sensor.Name + tSuffix;
        }

        // 값 + 단위 (% / ℃ / W / MHz 등)
        private string FormatSensorValue(Sensor_model sensor , float? value)
        {
            if ( !value.HasValue )
            {
                return string.Empty;
            }

            if ( float.IsNaN(value.Value) )
            {
                return string.Empty;
            }

            string tUnit = sensor.SensorType switch
            {
                SensorType.Load        => " %",
                SensorType.Temperature => " ℃",
                SensorType.Power       => " W",
                SensorType.Clock       => " MHz",
                SensorType.Voltage     => " V",
                SensorType.Fan         => " RPM",
                _                      => string.Empty
            };

            return $"{value.Value:F2}{tUnit}";
        }

        public void Dispose()
        {
            _view.RefreshTimer.Stop();
            _view.RefreshTimer.Dispose();
        }
    }
}
