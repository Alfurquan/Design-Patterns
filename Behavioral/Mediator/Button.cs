using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Button : UIControl
    {
        private bool isEnabled;

        public bool IsEnabled()
        {
            return isEnabled;
        }

        public void SetEnabled(bool value)
        {
            isEnabled = value;
            Notify(this, "button");
        }
    }
}
