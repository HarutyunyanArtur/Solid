using System;

namespace Solid_DIP
{
    public abstract class Radio : IRadio
    {
        public abstract void Receive();

        public void TurnOffRadio()
        {
            Console.WriteLine("Radio is off");
        }

        public void TurnOnRadio()
        {
            Console.WriteLine("Radio is on");
        }
    }
}
