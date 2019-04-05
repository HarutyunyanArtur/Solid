using System;

namespace Solid_DIP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new PionerRadio());
            car.Radio.TurnOnRadio();
            car.Radio.Receive();
            car.Radio.TurnOffRadio();
            car.Radio = new SonyRadio();
            car.Radio.TurnOnRadio();
            car.Radio.Receive();
            car.Radio.TurnOffRadio();
        }
    }
}