using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Exercise
{
    public class Text : IComponent
    {
        private string content;

        public Text(string content)
        {
            this.content = content;
        }

        public IComponent Clone()
        {
            var newText = new Text(content);
            return newText;
        }
    }
}
