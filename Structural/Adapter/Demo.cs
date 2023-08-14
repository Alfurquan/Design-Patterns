using DesignPatterns.Structural.Adapter.AvaFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class Demo
    {
        public static void Run()
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            imageView.Apply(new CaramelFilter(new Caramel()));
        }
    }
}
