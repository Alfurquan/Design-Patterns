using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Exercise
{
    public class ArabianCalendar : Calendar
    {
        public void AddEvent(Event eventDetails, DateTime date)
        {
            Console.WriteLine("Adding event to Arabian calendar");
        }
    }
}
