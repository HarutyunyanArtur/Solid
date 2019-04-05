namespace Solid_DIP
{
    public class Car
    {
        public IRadio Radio { get; set; }

        public Car(IRadio radio)
        {
            this.Radio = radio;
        }

        public Car() { }
    }
}
