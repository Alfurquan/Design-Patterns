using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.FX
{
    public class Button
    {
        public string Label { get; set; }
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }
    }
}
