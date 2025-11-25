using LibreHardwareMonitor.Hardware;

namespace SimpleHWInfo.Provider
{
    public class HardwareMonitorProvider : ASingleton<HardwareMonitorProvider>
    {
        private readonly Computer _computer;

        private HardwareMonitorProvider() 
        {
            _computer = new Computer
            {
                IsCpuEnabled = true ,
                IsGpuEnabled = true ,
                IsMotherboardEnabled = true ,
                IsMemoryEnabled = true ,
                IsControllerEnabled = false ,
                IsNetworkEnabled = true ,
                IsStorageEnabled = true
            };

            _computer.Open();
        }

        
    }
}
