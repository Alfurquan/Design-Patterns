using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Demo
    {
        public static void Run()
        {
            var group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());

            var group2 = new Group();   
            group2.Add(new Shape());
            group2.Add(new Shape());

            var group = new Group();
            group.Add(group1);
            group.Add(group2);
            group.Render();
            group.Move();

        }
    }
}
