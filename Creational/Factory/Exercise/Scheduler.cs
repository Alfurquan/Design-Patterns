using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Exercise
{
    public class Scheduler
    {

        public void Schedule(Event eventDetails)
        {
            Calendar calendar = GetCalendar();
            var today = DateTime.Today;
            calendar.AddEvent(eventDetails, today);
        }

        public virtual Calendar GetCalendar()
        {
            return new GregorianCalendar();
        }
    }
}
