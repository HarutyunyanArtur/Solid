using System;

namespace Solid_DIP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new PionerRadio());
            car.Radio.TurnOnRadio();
            car.Radio.Receive();
            car.Radio.TurnOffRadio();
        }
    }

    class Car
    {
        public PionerRadio Radio { get; set; }

        public Car(PionerRadio radio)
        {
            this.Radio = radio;
        }
    }

    class PionerRadio 
    {
        public void Receive()
        {
            Console.WriteLine("Pioner Radio");
        }

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
