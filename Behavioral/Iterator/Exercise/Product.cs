using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator.Exercise
{
    public class Product
    {
        private int Id { get; set;  }
        private string Name { get; set; }
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return "Product{" +
                    "id=" + Id +
                    ", name='" + Name + '\'' +
                    '}';
        }
    }
}
