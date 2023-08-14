using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class SonyTV : IDevice
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Sony TV set channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony TV turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony TV turn on");
        }
    }
}
