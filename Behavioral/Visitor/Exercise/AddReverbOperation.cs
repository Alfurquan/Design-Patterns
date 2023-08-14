using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Exercise
{
    public class AddReverbOperation : IOperation
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Add reverb - fact segment");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Add reverb - format segment");
        }
    }
}
