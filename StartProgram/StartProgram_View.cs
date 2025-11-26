namespace SimpleHWInfo.StartProgram
{
    public enum PROGRAM_MODE
    {
        FULL_SENSOR_MODE,
        SIMPLE_SENSOR_MODE,
    }

    public partial class StartProgram_View : Form
    {
        private readonly StartProgram_Presenter _presenter;

        public PROGRAM_MODE SelectedProgramMode
        {
            get
            {
                switch ( modeComboBox.SelectedIndex )
                {
                    case 0:
                        return PROGRAM_MODE.FULL_SENSOR_MODE;

                    case 1:
                        return PROGRAM_MODE.SIMPLE_SENSOR_MODE;

                    default:
                        return PROGRAM_MODE.FULL_SENSOR_MODE;
                }
            }
        }

        public StartProgram_View()
        {
            InitializeComponent();

            _presenter = new StartProgram_Presenter(this);

            modeComboBox.SelectedIndex = 0;
        }

        public void StartBtn_Click(object sender , EventArgs e)
        {
            _presenter.OnStartButtonClicked();
        }

        public void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _presenter.OnGithubLabelClicked("https://github.com/IIBluEll/Simple_Hardware_Info");
        }
    }
}
