
namespace SimpleHWInfo.LoadingView
{
    public partial class Loading_View : Form
    {
        public Loading_View()
        {
            InitializeComponent();
            SettingView();
        }
        
        private void SettingView()
        {
            var tLabel = new Label()
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "하드웨어 정보를 불러오는 중입니다...\n잠시만 기다려 주세요!"
            };

            Controls.Add(tLabel);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;
            Width = 360;
            Height = 130;

            TopMost = true;
        }
    }
}
