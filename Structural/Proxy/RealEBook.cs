using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class RealEBook : IEBook
    {
        private string fileName;

        public RealEBook(string fileName)
        {
            this.fileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine("Loading the book "  + fileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing the book " + fileName);
        }

        public string GetFileName()
        {
            return fileName;
        }
    }
}
