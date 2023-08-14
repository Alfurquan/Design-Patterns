using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Demo
    {
        public static void Run()
        {
            var service = new NotificationService();
            service.SendNotification("Hello World", "target");
        }
    }
}
