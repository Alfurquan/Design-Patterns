using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Exercise
{
    public class Driving : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }
    }
}
