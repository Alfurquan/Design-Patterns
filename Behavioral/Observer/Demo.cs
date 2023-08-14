using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Demo
    {
        public static void Run()
        {
            var dataSource = new DataSource();
            var sheet1 = new Spreadsheet(dataSource);
            var sheet2 = new Spreadsheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.SetValue(10);
        }
    }
}
