using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.Exercise
{
    public class DbContext
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public void SaveChanges()
        {
            foreach (var product in products.Values)
            {
               Console.WriteLine("UPDATE products SET name = '{0}' WHERE product_id = {1} \n", product.GetName(), product.GetId());
            }
            products.Clear();
        }

        public Product GetProduct(int id)
        {
            Console.WriteLine("SELECT * FROM products WHERE product_id = {0} \n", id);
            var product = new ProductProxy(id, this);

            product.SetName("Product 1");
            return product; 
        }

        public void MarkAsChanged(Product product)
        {
            products.Add(product.GetId(), product);
        }
    }
}
