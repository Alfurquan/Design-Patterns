using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class NotificationService
    {
        public void SendNotification(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ipAddress");
            var authToken = server.Authenticate("appID", "key");
            server.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}
