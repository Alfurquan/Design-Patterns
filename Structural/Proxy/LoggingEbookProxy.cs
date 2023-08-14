using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class LoggingEbookProxy : IEBook
    {
        private string fileName;

        public LoggingEbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        private RealEBook ebook;
        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if (ebook == null)
            {
                ebook = new RealEBook(fileName);
            }
            Console.WriteLine("Logging");
            ebook.Show();
        }
    }
}
