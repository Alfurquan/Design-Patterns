using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class BWFilter : IFilter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
