using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template.Exercise
{
    public abstract class Window
    {
        // The close method is defining a template. Custom window classes
        // can use this template and determine what should happen before and
        // after a window is closed.
        public void Close()
        {
            OnClosing();

            Console.WriteLine("Removing the window from the screen");

            OnClosed();
        }

        protected abstract void OnClosing();
        protected abstract void OnClosed();
    }

}
