using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template
{
    public class Demo
    {
        public static void Run()
        {
            var task = new TransferMoneyTask();
            task.Execute();
        }
    }
}
