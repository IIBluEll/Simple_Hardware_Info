using SimpleHWInfo.LoadingView;
using SimpleHWInfo.Provider;
using SimpleHWInfo.StartProgram;
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            if ( e.CloseReason == CloseReason.WindowsShutDown ||
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
