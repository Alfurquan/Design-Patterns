using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Exercise
{
    public class Timeline
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent component)
        {
            components.Add(component);
        }
    }
}
