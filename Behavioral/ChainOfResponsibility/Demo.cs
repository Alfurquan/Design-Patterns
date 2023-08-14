using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Demo
    {
        public static void Run()
        {
            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);
            var webServer = new WebServer(authenticator);
            webServer.Handle(new HttpRequest { Username = "admin", Password = "1234" });
        }
    }
}
