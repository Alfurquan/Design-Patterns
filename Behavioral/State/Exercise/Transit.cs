using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Exercise
{
    public class Transit : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }
    }
}
