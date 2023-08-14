using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class Demo
    {
        public static void Run()
        {
            var service = new PointService(new PointIconFactory());
            var points = service.GetPoints();

            foreach (var point in points)
            {
                point.Draw();
            }
        }
    }
}
