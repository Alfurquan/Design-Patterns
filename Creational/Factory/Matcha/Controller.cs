using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Matcha
{
    public class Controller
    {
        public void Render(string viewName, Dictionary<string, object> model)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, model);
            Console.WriteLine(html);
        }

        protected virtual IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}
