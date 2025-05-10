using System;
namespace ConsoleApp1
{
    class SmartDevice
    {
        public string DeviceName;
        public bool PowerStatus;

        public void TogglePower()
        {
            Console.WriteLine($"Power status changed {PowerStatus}");
        }
    }
    class SmartLight : SmartDevice
    {
        public int Brightness;
        public void ChangeBrightness(int Brightness)
        {
            this.Brightness = Brightness;
            Console.WriteLine($"The brightness is changed : {Brightness}");
        }
        
    }
    class SmartThermostat : SmartLight
    {
        public double Temperature;
        public void ChangeTemperature(double Temperature)
        {
            this.Temperature = Temperature;
            Console.WriteLine($"The temperature is changed to : {Temperature}");
        }
    }
    class Program
    {
        static void Main()
        {
            SmartThermostat smartthermo = new SmartThermostat();
            smartthermo.TogglePower();
            smartthermo.ChangeBrightness(90);
            smartthermo.ChangeTemperature(12.5);
        }
    }

}

