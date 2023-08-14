using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Demo
    {
        public static void Run()
        {
            var presentation = new Presentation();
            presentation.AddSlide(new Slide("Slide 1"));
            presentation.AddSlide(new Slide("Slide 2"));

            var builder = new MovieBuilder();
            presentation.Export(builder);
            builder.GetMovie();
        }
    }
}
