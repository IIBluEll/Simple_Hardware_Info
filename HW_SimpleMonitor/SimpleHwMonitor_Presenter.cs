using LibreHardwareMonitor.Hardware;
using SimpleHWInfo.Provider;

namespace SimpleHWInfo.HW_SimpleMonitor
{
    public class SimpleHwMonitor_Presenter : IDisposable
    {
        private readonly SImpleHwMonitor_View _view;
        private readonly System.Windows.Forms.Timer _timer;

        public SimpleHwMonitor_Presenter(SImpleHwMonitor_View view)
        {
            _view = view;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += async (s , e) => await OnTick_async();
            _timer.Start();
        }

        private async Task OnTick_async()
        {
            HardwareRawSnapshot_model tSanp = await Task.Run(() =>
            {
                return HardwareMonitorProvider.Instance.GetRawSnapshot();
            });

            var tCpuNode = tSanp.list_Hardwares.FirstOrDefault(h => h.HardwareType == HardwareType.Cpu);

            var tGpuNode = tSanp.list_Hardwares.FirstOrDefault(h => h.HardwareType == HardwareType.GpuNvidia || h.HardwareType == HardwareType.GpuAmd || h.HardwareType == HardwareType.GpuNvidia);

            if(tCpuNode != null)
            {
                var tCpuInfo = MakeSimpleHwInfo(tCpuNode);
                _view.SetCpuInfo(tCpuInfo);
            }

            if ( tGpuNode != null )
            {
                var tGpuInfo = MakeSimpleHwInfo(tGpuNode);
                _view.SetGpuInfo(tGpuInfo);
            }
        }

        private SimpleHwMonitor_Model MakeSimpleHwInfo(HardwareNode_model hwNode)
        {
            var tList_Sensors = GetSensors(hwNode);

            float tClock = GetAverageValue(tList_Sensors, SensorType.Clock);
            float tTemp = GetAverageValue(tList_Sensors, SensorType.Temperature);
            float tUsage = GetUsageValue(tList_Sensors);

            return new SimpleHwMonitor_Model
            {
                Name = hwNode.Name ,
                ClockMhz = tClock ,
                TempC = tTemp ,
                Usage = tUsage
            };
        }

        private List<Sensor_model> GetSensors(HardwareNode_model node)
        {
            var list_result = new List<Sensor_model>();

            void Traverse(HardwareNode_model tNode)
            {
                list_result.AddRange(tNode.list_Sensors);

                foreach ( var tSub in tNode.list_SubHardwares )
                {
                    Traverse(tSub);
                }
            }

            Traverse(node);

            return list_result;
        }

        private float GetAverageValue(List<Sensor_model> list, SensorType type)
        {
            var tList_Valid = list.Where(s => s.SensorType == type && s.Value.HasValue && !float.IsNaN(s.Value.Value)).ToList();

            if(tList_Valid.Count == 0)
            {
                return 0f;
            }

            return tList_Valid.Average(s=> s.Value.Value);
        }

        private float GetUsageValue(List<Sensor_model> list)
        {
            var tList_Usage = list.Where(s=>s.SensorType == SensorType.Load && s.Value.HasValue && !float.IsNaN(s.Value.Value)).ToList();

            if ( tList_Usage.Count == 0 )
            {
                return 0f;
            }

            string[] arr_keys =
            {
                "CPU Total",
                "GPU Core",
                "GPU Utilization"
            };

            foreach ( var tKey in arr_keys )
            {
                var tMatch = tList_Usage
            .FirstOrDefault(s => s.Name.IndexOf(tKey , StringComparison.OrdinalIgnoreCase) >= 0);

                if ( tMatch != null )
                {
                    return tMatch.Value!.Value;
                }
            }

            return tList_Usage.Average(s => s.Value!.Value);
        }

        public void Dispose()
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
