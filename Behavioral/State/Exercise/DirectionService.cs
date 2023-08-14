using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Exercise
{
    public class DirectionService
    {
        public ITravelMode TravelMode { get; set; }

        public int getEta()
        {
            return TravelMode.GetEta();
        }

        public int getDirection()
        {
            return TravelMode.GetDirection(); 
        }
    }
}
