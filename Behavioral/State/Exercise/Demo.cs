using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var directionService = new DirectionService();
            directionService.TravelMode = new Transit();
            Console.WriteLine(directionService.getDirection());
            Console.WriteLine(directionService.getEta());
        }
    }
}
