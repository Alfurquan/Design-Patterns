using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var productCollection = new ProductCollection();
            productCollection.Add(new Product(1, "a"));
            productCollection.Add(new Product(2, "b"));
            productCollection.Add(new Product(3, "c"));

            IIterator<Product> iterator = productCollection.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }
    }
}
