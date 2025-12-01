using SimpleHWInfo.LoadingView;
using SimpleHWInfo.Provider;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SimpleHWInfo.HW_FullMonitor
{
    public partial class HwFullMonitor_View : Form
    {
        private readonly HwFullMonitor_Presenter _presenter;
        public Timer RefreshTimer;

        public ListView HardWareListView => hardWareListView;

        public HwFullMonitor_View()
        {
            InitializeComponent();

            _presenter = new HwFullMonitor_Presenter(this);

            // ListView 설정
            hardWareListView.View = View.Details;
            hardWareListView.FullRowSelect = true;
            hardWareListView.GridLines = true;
            hardWareListView.HideSelection = false;

            // 타이머 설정
            RefreshTimer = new Timer();
            RefreshTimer.Interval = 1000;
            RefreshTimer.Tick += RefreshTimer_Tick;

            Shown += HwFullMonitor_View_Shown;
        }

        private async void HwFullMonitor_View_Shown(object? sender , EventArgs e)
        {
            await _presenter.LoadingStart_async();
        }

        private async void RefreshTimer_Tick(object sender , EventArgs e)
        {
            // 이전 Tick이 아직 끝나지 않았는데 다시 진입하는 것 방지
            RefreshTimer.Enabled = false;

            try
            {
                await _presenter.RefreshSensor_async();
            }
            finally
            {
                RefreshTimer.Enabled = true;
            }
        }
    }
}
