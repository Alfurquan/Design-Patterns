using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Ant
{
    public class AntTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant text box");
        }
    }
}
