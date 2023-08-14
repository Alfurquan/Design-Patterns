using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var logger1 = Logger.GetInstance("file1.txt");
            var logger2 = Logger.GetInstance("file2.txt");

            Console.WriteLine(logger1 == logger2);

            var logger3 = Logger.GetInstance("file1.txt");
            Console.WriteLine(logger1 == logger3);
        }
    }
}
