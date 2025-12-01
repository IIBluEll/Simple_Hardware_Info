using HidSharp.Utility;
using SimpleHWInfo.StartProgram;

namespace SimpleHWInfo.HW_SimpleMonitor
{
    public enum CpuBrand
    {
        Unknown,
        Intel,
        Amd,
    }

    public enum GpuBrand
    {
        Unknown,
        Nvidia,
        Amd,
        Intel
    }

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

            cpuPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            gpuPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            _presenter = new SimpleHwMonitor_Presenter(this);

            Shown += SImpleHwMonitor_View_Shown;
        }

        private async void SImpleHwMonitor_View_Shown(object? sender , EventArgs e)
        {
            await _presenter.InitView_async();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            if(e.CloseReason == CloseReason.WindowsShutDown ||
                 e.CloseReason == CloseReason.ApplicationExitCall )
            {
                return;
            }

            var tResult = MessageBox.Show
                (
                    this,
                    "완전히 종료하시겠습니까?\r\n\r\n"+
                    "예    : 프로그램 완전 종료\r\n"+
                    "아니오 : 모드 선택 화면으로 돌아가기\r\n"+
                    "취소   : 이 창 유지",
                    "종료 확인",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

            switch ( tResult )
            {
                case DialogResult.Yes:

                    Application.Exit();
                    break;

                case DialogResult.No:

                    ShowStartView();
                    break;

                case DialogResult.Cancel:
                default:

                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _presenter.Dispose();
        }

        private void ShowStartView()
        {
            var tStartView = Application.OpenForms.OfType<StartProgram_View>().FirstOrDefault();

            if ( tStartView == null || tStartView.IsDisposed )
            {
                tStartView = new StartProgram_View();
            }

            tStartView.Show();
            tStartView.BringToFront();
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

        public void SetCpuBrandIcon(CpuBrand brand)
        {
            switch ( brand )
            {
                case CpuBrand.Intel:

                    cpuPictureBox.Image = Properties.Resources.intel;
                    break;

                case CpuBrand.Amd:
                    cpuPictureBox.Image = Properties.Resources.amd;
                    break;

                case CpuBrand.Unknown:
                    cpuPictureBox.Image = Properties.Resources.unknown;
                    break;
            }
        }

        public void SetGpuBrandIcon(GpuBrand brand)
        {
            switch ( brand )
            {
                case GpuBrand.Nvidia:
                    gpuPictureBox.Image = Properties.Resources.nvidia;
                    break;

                case GpuBrand.Amd:
                    gpuPictureBox.Image = Properties.Resources.amd;
                    break;

                case GpuBrand.Intel:
                    gpuPictureBox.Image = Properties.Resources.intel;
                    break;

                default:
                    gpuPictureBox.Image = Properties.Resources.unknown;
                    break;
            }
        }

        private void gpuClockLabel_TextChanged(object sender , EventArgs e)
        {

        }
    }
}
