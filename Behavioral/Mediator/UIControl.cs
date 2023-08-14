using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class UIControl
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        protected void Notify(UIControl control, string ev)
        {
            foreach (var observer in observers)
                observer.Update(control, ev);
        }
       
    }
}
