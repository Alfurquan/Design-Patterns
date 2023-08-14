using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Exercise
{
    public class ReduceNoiseOperation : IOperation
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Reduce noise - fact segment");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Reduce noise - format segment");
        }
    }
}
