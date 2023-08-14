using DesignPatterns.Structural.Adapter.Exercise.Gmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var emailClient = new EmailClient();
            emailClient.Add(new GmailProvider());
            emailClient.DownloadEmails();
        }
    }
}
