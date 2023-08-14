using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.App
{
    public class ContactForm
    {
        public void Render(IWidgetFactory widgetFactory)
        {
            widgetFactory.CreateTextBox().Render();
            widgetFactory.CreateButton().Render();
        }
    }
}
