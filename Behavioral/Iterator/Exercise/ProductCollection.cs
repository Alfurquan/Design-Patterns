using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator.Exercise
{
    public class ProductCollection
    {

        class ListIterator : IIterator<Product>
        {
            private ProductCollection productCollection;
            private int index;

            public ListIterator(ProductCollection productCollection)
            {
                this.productCollection = productCollection;
            }

            public bool HasNext()
            {
                return index < productCollection.products.Count;
            }

            public Product Current()
            {
                return productCollection.products[index];
            }

            public void Next()
            {
                index++;
            }
        }

        private List<Product> products = new List<Product>();

        public IIterator<Product> CreateIterator()
        {
            return new ListIterator(this);
        }

        public void Add(Product product)
        {
            products.Add(product);
        }
    }
}
