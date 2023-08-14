using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Demo
    {
        public static void Run()
        {
            var library = new Library();
            string[] fileNames = { "a", "b", "c" };

            foreach (var fileName in fileNames)
            {
                library.AddBook(new LoggingEbookProxy(fileName));
            }

            library.OpenBook("a");
            library.OpenBook("b");
        }
    }
}
