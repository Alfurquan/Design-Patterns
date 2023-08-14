using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Exercise
{
    public interface Calendar
    {
        void AddEvent(Event eventDetails, DateTime date);
       
    }
}
