namespace SimpleHWInfo.HW_SimpleMonitor
{
    public partial class SImpleHwMonitor_View : Form
    {
        private readonly SimpleHwMonitor_Presenter _presenter;

        public SImpleHwMonitor_View()
        {
            InitializeComponent();

            cpuTempProgress.Maximum = 100;
            cpuUsageProgress.Maximum = 100;
            gpuTempProgress.Maximum = 100;
            gpuUsageProgress.Maximum = 100;

            cpuGroup.Text = "CPU Simple Info";
            gpuGroup.Text = "GPU Simple Info";

            _presenter = new SimpleHwMonitor_Presenter(this);

            Shown += SImpleHwMonitor_View_Shown;
        }

        private async void SImpleHwMonitor_View_Shown(object? sender , EventArgs e)
        {
            await _presenter.InitView_async();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _presenter.Dispose();
        }

        public void SetCpuInfo(SimpleHwMonitor_Model cpuInfo)
        {
            if ( cpuInfo == null )
            {
                return;
            }

            cpuNameLabel.Text = cpuInfo.Name;
            cpuClockLabel.Text = cpuInfo.ClockMhz.ToString("F0");
            cpuTempLabel.Text = cpuInfo.TempC.ToString("F2");
            cpuUsageLabel.Text = cpuInfo.Usage.ToString("F0");

            cpuTempProgress.Value = ClampToBar(cpuInfo.TempC , cpuTempProgress);
            cpuUsageProgress.Value = ClampToBar(cpuInfo.Usage , cpuUsageProgress);
        }

        public void SetGpuInfo(SimpleHwMonitor_Model gpuInfo)
        {
            if ( gpuInfo == null )
            {
                return;
            }

            gpuNameLabel.Text = gpuInfo.Name;
            gpuClockLabel.Text = gpuInfo.ClockMhz.ToString("F0");
            gpuTempLabel.Text = gpuInfo.TempC.ToString("F2");
            gpuUsageLabel.Text = gpuInfo.Usage.ToString("F0");

            gpuTempProgress.Value = ClampToBar(gpuInfo.TempC , gpuTempProgress);
            gpuUsageProgress.Value = ClampToBar(gpuInfo.Usage , gpuUsageProgress);
        }

        private int ClampToBar(float value , ProgressBar bar)
        {
            if ( float.IsNaN(value) )
            {
                return 0;
            }

            int tVal = (int)Math.Round(value);

            if ( tVal < bar.Minimum )
            {
                tVal = bar.Minimum;
            }

            if ( tVal > bar.Maximum )
            {
                tVal = bar.Maximum;
            }

            return tVal;
        }

        private void gpuClockLabel_TextChanged(object sender , EventArgs e)
        {

        }
    }
}
