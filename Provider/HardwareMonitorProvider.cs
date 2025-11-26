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

        private void UpdateAllHardware()
        {
            foreach ( var tHardware in _computer.Hardware )
            {
                tHardware.Update();

                foreach ( var tSub in tHardware.SubHardware )
                {
                    tSub.Update();
                }
            }
        }

        public HardwareRawSnapshot_model GetRawSnapshot()
        {
            UpdateAllHardware();

            var tSnapshot = new HardwareRawSnapshot_model();

            foreach ( var tHardware in _computer.Hardware )
            {
                var tNode = BuildHardwareNode(tHardware);
                tSnapshot.list_Hardwares.Add(tNode);
            }

            return tSnapshot;
        }

        private HardwareNode_model BuildHardwareNode(IHardware hardware)
        {
            var tNode = new HardwareNode_model
            {
                Name = hardware.Name,
                HardwareType = hardware.HardwareType
            };

            foreach ( var tSensor in hardware.Sensors )
            {
                var tSensorModel = new Sensor_model
                {
                    Name = tSensor.Name,
                    SensorType = tSensor.SensorType,
                    Value = tSensor.Value,
                    Min = tSensor.Min,
                    Max = tSensor.Max,
                    Identifier = tSensor.Identifier.ToString()
                };

                tNode.list_Sensors.Add(tSensorModel);
            }

            foreach ( var tSub in hardware.SubHardware )
            {
                var tSubNode = BuildHardwareNode(tSub);
                tNode.list_SubHardwares.Add(tSubNode);
            }

            return tNode;
        }

        public void Dispose()
        {
            _computer.Close();
        }
    }

    public class Sensor_model
    {
        public string Name;
        public SensorType SensorType;
        public float? Value;
        public float? Min;
        public float? Max;
        public string Identifier;
    }

    public class HardwareNode_model
    {
        public string Name;
        public HardwareType HardwareType;
        public List<Sensor_model> list_Sensors = new List<Sensor_model>();
        public List<HardwareNode_model> list_SubHardwares = new List<HardwareNode_model>();
    }

    public class HardwareRawSnapshot_model
    {
        public List<HardwareNode_model> list_Hardwares = new List<HardwareNode_model>();
    }
}
