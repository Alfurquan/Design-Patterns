using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Exercise
{
    public class Truck : IResource
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying truck");
        }
    }
}
