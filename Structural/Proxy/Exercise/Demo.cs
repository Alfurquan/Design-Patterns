using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var dbContext = new DbContext();
            var product = dbContext.GetProduct(1);

            product.SetName("Updated Name");
            dbContext.SaveChanges();

            product.SetName("Another name");
            dbContext.SaveChanges();
        }
    }
}
