using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Exercise
{
    public interface ITravelMode
    {
        int GetEta();
        int GetDirection();
    }
}
