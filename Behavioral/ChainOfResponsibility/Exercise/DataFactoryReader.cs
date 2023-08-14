using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Exercise
{
    public class DataFactoryReader
    {
        public static DataReader GetDataReaderChain()
        {
            var excelReader = new ExcelReader(null);
            var numbersReader = new NumbersReader(excelReader);
            var quickBookReader = new QuickBookReader(numbersReader);
            return quickBookReader;
        }
    }
}
