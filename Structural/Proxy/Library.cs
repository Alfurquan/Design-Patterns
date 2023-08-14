using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Library
    {
        private Dictionary<string, IEBook> books = new Dictionary<string, IEBook>();

        public void AddBook(IEBook eBook)
        {
            books.Add(eBook.GetFileName(), eBook);
        }

        public void OpenBook(string fileName)
        {
            if(!books.ContainsKey(fileName))
            {
                Console.WriteLine("Book not found!");
                return;
            }
            books[fileName].Show();
        }
    }
}
