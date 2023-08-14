using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Movie
    {
        public void AddFrame(string text)
        {
            Console.WriteLine("Adding a frame to the movie");
        }
    }
}
