using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Exercise
{
    public class BuildMuscleMealPlan : IMealPlan
    {
        public void PrintPlan()
        {
            Console.WriteLine("Build muscle meal plan");
        }
    }
}
