using SimpleHWInfo.StartProgram;

namespace SimpleHWInfo.Provider
{
    public sealed class ProgramLuncherProvider
    {
        public void Launch(PROGRAM_MODE mode)
        {
            switch ( mode )
            {
                case PROGRAM_MODE.FULL_MODE:
                    break;

                case PROGRAM_MODE.SENSOR_ONLY:
                    break;

                case PROGRAM_MODE.INFORMATION_ONLY:
                    break;
            }
        }
    }
}
