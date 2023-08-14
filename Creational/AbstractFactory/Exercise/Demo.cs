using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var page = new HomePage();
            page.SetGoal(new BuildMusclePlanFactory());
        }
    }
}
