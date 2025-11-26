using Timer = System.Windows.Forms.Timer;

namespace SimpleHWInfo.HW_FullMonitor
{
    public partial class HwFullMonitor_View : Form
    {
        private readonly HwFullMonitor_Presenter _presenter;
        private Timer _refreshTimer;

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
            _refreshTimer = new Timer();
            _refreshTimer.Interval = 1000;
            _refreshTimer.Tick += RefreshTimer_Tick;
            _refreshTimer.Start();
        }

        private async void RefreshTimer_Tick(object sender , EventArgs e)
        {
            // 이전 Tick이 아직 끝나지 않았는데 다시 진입하는 것 방지
            _refreshTimer.Enabled = false;

            try
            {
                await _presenter.RefreshSensor_async();
            }
            finally
            {
                _refreshTimer.Enabled = true;
            }
        }
    }
}
