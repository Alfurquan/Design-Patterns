using DesignPatterns.Structural.Adapter.Exercise.Gmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Exercise
{
    public class GmailProvider : IEmailProvider
    {
        private GmailClient client;

        public GmailProvider()
        {
           this.client = new GmailClient();
        }

        public void DownloadEmails()
        {
            client.Connect();
            client.GetEmails();
            client.Disconnet();
        }
    }
}
