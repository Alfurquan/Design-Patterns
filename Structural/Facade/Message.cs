using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Message
    {
        private string content;

        public Message(string content)
        {
            this.content = content;
        }
    }
}
