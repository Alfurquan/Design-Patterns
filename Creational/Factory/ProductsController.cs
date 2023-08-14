using DesignPatterns.Creational.Factory.Matcha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class ProductsController : SharpController
    {
        public void ListProducts()
        {
            var model = new Dictionary<string, object>();
            model.Add("products", new List<string> { "Apple", "Banana", "Orange" });
            Render("products.html", model);
        }
    }
}
