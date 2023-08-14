using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template.Exercise
{
    public class ChatWindow : Window
    {
        protected override void OnClosed()
        {
            Console.WriteLine("Window is closed");
        }

        protected override void OnClosing()
        {
            Console.WriteLine("Disconnecting from server");
        }
    }
}
