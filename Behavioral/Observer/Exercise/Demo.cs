using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var statusBar = new StatusBar();
            var stock1 = new Stock("stock1", 10);
            var stock2 = new Stock("stock2", 20);
            var stockListView = new StockListView();

            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);

            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);

            stock1.AddObserver(statusBar);
            stock1.AddObserver(stockListView);

            stock1.SetPrice(11);
        }
    }
}
