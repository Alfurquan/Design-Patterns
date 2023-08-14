using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var scheduler = new Scheduler();
            scheduler.Schedule(new Event());

            scheduler = new ArabianScheduler();
            scheduler.Schedule(new Event());
        }
    }
}
