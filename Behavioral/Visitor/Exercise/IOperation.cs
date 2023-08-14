using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Exercise
{
    public interface IOperation
    {
        void Apply(FactSegment factSegment);
        void Apply(FormatSegment formatSegment);
    }
}
