using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Chart : IObserver
    {
        private DataSource dataSource;

        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            int value = dataSource.GetValue();
            Console.WriteLine("Chart got updated with value : " + value);
        }
    }
}
