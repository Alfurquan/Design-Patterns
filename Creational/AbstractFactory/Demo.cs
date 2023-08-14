using DesignPatterns.Creational.AbstractFactory.Ant;
using DesignPatterns.Creational.AbstractFactory.App;
using DesignPatterns.Creational.AbstractFactory.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Demo
    {
        public static void Run()
        {
            var form = new ContactForm();
            form.Render(new AntWidgetFactory());
        }
    }
}
