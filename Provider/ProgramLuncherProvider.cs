using SimpleHWInfo.HW_FullMonitor;
using SimpleHWInfo.StartProgram;

namespace SimpleHWInfo.Provider
{
    public sealed class ProgramLuncherProvider
    {
        public void Launch(PROGRAM_MODE mode)
        {
            switch ( mode )
            {
                case PROGRAM_MODE.FULL_SENSOR_MODE:

                    var tHwMonitorForm = new HwFullMonitor_View();
                    tHwMonitorForm.Show();
                    break;

                case PROGRAM_MODE.SIMPLE_SENSOR_MODE:

                    break;
            }
        }
    }
}
