using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Exercise
{
    public class Walking : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (walking)");
            return 4;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 4;
        }
    }
}
