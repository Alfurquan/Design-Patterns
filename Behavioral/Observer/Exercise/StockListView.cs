using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Exercise
{
    public class StockListView : IObserver
    {
        private List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }

        public void Show()
        {
            foreach (var stock in stocks)
            {
                Console.WriteLine(stock);
            }
        }

        public void Update()
        {
            Console.WriteLine("Stock list view is updated");
        }
    }
}
