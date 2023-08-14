using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class Demo
    {
        public static void Run()
        {
            var controller = new ProductsController();
            controller.ListProducts();
        }
    }
}
