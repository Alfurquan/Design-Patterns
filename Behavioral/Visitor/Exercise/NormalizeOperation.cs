using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Exercise
{
    public class NormalizeOperation : IOperation
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Normalize - fact segment");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalize - format segment");
        }
    }
}
