using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Exercise
{
    public abstract class DataReader
    {
        private DataReader next;

        public DataReader(DataReader next)
        {
            this.next = next;
        }

        public void Read(string fileName)
        {
            if (DoRead(fileName))
                return;

            if (next != null)
                next.Read(fileName);
        }

        protected abstract bool DoRead(string fileName);

        protected abstract string getExtension();
    }
}
