using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class PointService
    {
        private PointIconFactory iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            return new List<Point>
            {
                new Point(1, 2, iconFactory.GetPointIcon(PointType.Hospital)),
                new Point(3, 4, iconFactory.GetPointIcon(PointType.Cafe)),
                new Point(5, 6, iconFactory.GetPointIcon(PointType.Restaurant))
            };
        }
    }
}
