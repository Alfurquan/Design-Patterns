using DesignPatterns.Creational.Factory.Matcha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Sharp
{
    public class SharpViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> model)
        {
            return "View rendered by Sharp";
        }
    }
}
