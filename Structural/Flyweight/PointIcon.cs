using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class PointIcon
    {
        private readonly PointType type;
        private readonly byte[] icon;

        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }

        public PointType GetType()
        {
            return type;
        }

    }
}
