using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class TextBox : UIControl
    {
        private string content;

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string value)
        {
            content = value;
            Notify(this, "textbox");
        }
    }
}
