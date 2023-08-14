using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Spreadsheet : IObserver
    {
        private DataSource dataSource;

        public Spreadsheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            int value = dataSource.GetValue();
            Console.WriteLine("Spreadsheet got notified." + value);
        }
    }
}
