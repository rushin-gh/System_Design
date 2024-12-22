/*
    Dependency Inversion Principle (DIP)
        High-level modules should not depend on low-level modules. Both should depend on abstractions. 
        Abstractions should not depend on details. Details should depend on abstractions.
*/

using Good_Way;

namespace Dependancy_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Good_Way.ISwitchable Fan = new Good_Way.Fan();
            Switch fanSwitch = new Switch(Fan);
            fanSwitch.Operate();
        }
    }
}

namespace Bad_Way
{
    // Low Level Module
    public class LightBulb
    {
        public void TurnOn()
        {
            // LightBulb on
        }

        public void TurnOff()
        {
            // LightBulb off
        }
    }

    // High Level Module
    public class Switch
    {
        private LightBulb _lightBulb;

        public Switch(LightBulb lightBulb)
        {
            _lightBulb = lightBulb;
        }

        public void Operate()
        {
            // Code to turn the light bulb on or off
        }
    }

    /*
         When a new device comes like Fan we will need to
         Modify Switch class
    */
}

namespace Good_Way
{
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
    }

    public class LightBulb : ISwitchable
    {
        public void TurnOn()
        {
            // LightBulb on
        }

        public void TurnOff()
        {
            // LightBulb off
        }
    }

    public class Fan : ISwitchable
    {
        public void TurnOn()
        {
            // Fan on
        }

        public void TurnOff()
        {
            // Fan off
        }
    }

    public class Switch
    {
        private ISwitchable _device;

        public Switch(ISwitchable device)
        {
            _device = device;
        }

        public void Operate()
        {
            // Code to turn the device on or off
        }
    }
}