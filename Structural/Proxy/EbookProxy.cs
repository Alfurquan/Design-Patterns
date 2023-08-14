using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class EbookProxy : IEBook
    {
        private string fileName;
        private RealEBook ebook;
        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if(ebook == null)
            {
                ebook = new RealEBook(fileName);
            }
            ebook.Show();
        }
    }
}
