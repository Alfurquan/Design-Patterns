using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var sheet = new SpreadSheet(new CellContextFactory());
            sheet.SetContent(0, 0, "Hello");
            sheet.SetContent(1, 0, "World");
            sheet.SetFontFamily(0, 0, "Arial");
            sheet.Render();
        }
    }
}
