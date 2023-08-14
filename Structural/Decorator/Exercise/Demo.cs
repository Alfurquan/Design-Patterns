using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var editor = new Editor();
            editor.openProject("...");
        }
    }
}
