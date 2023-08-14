using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Exercise
{
    public class NumbersReader : DataReader
    {
        public NumbersReader(DataReader next) : base(next)
        {
        }

        protected override bool DoRead(string fileName)
        {
            Console.WriteLine("Numbers reader reading filename " + fileName);
            return false;
        }

        protected override string getExtension()
        {
            return ".numbers";
        }
    }
}
