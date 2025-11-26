using SimpleHWInfo.Provider;
using System.Diagnostics;

namespace SimpleHWInfo.StartProgram
{
    public class StartProgram_Presenter
    {
        private readonly StartProgram_View _view;
        private readonly ProgramLuncherProvider _luncherProvider;

        public StartProgram_Presenter(StartProgram_View view)
        {
            _view = view;
            _luncherProvider = new ProgramLuncherProvider();
        }

        public void OnStartButtonClicked()
        {
            var tMode = _view.SelectedProgramMode;
            _luncherProvider.Launch(tMode);

            _view.Hide();
        }

        public void OnGithubLabelClicked(string gitHubLink)
        {
            try
            {
                var tInfo = new ProcessStartInfo
                {
                    FileName = gitHubLink,
                    UseShellExecute = true,
                };

                Process.Start( tInfo );
            }
            catch ( Exception ex )
            {
                MessageBox.Show
                (
                    _view ,
                    "기본 브라우저를 열 수 없습니다.\n" + ex.Message ,
                    "오류" ,
                    MessageBoxButtons.OK ,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
