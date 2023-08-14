using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var document = new Document();
            var history = new History();

            document.Content = "Hello";
            history.Push(document.CreateState());

            document.FontName = "Font 1";
            history.Push(document.CreateState());

            document.FontSize = 10;

            Console.WriteLine(document);

            document.Restore(history.Pop());
            Console.WriteLine(document);

            document.Restore(history.Pop());
            Console.WriteLine(document);
        }
    }
}
