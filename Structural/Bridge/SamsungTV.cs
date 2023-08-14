using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class SamsungTV : IDevice
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Samsung TV set channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung TV turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung TV turn on");
        }
    }
}
