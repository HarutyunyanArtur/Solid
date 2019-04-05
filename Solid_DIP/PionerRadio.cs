using System;

namespace Solid_DIP
{
    public class PionerRadio : Radio, IRadio
    {
        public override void Receive()
        {
            Console.WriteLine("Pioner Radio");
        }
    }
}
