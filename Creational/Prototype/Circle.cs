using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Circle : IComponent
    {
        public int Radius { get; set; }

        public IComponent Clone()
        {
            var newCircle = new Circle();
            newCircle.Radius = Radius;
            return newCircle;
        }

        public void Render()
        {
            Console.WriteLine("Rendering a circle");
        }
    }
}
