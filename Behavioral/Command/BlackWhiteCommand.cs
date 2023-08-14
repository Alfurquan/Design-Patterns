using DesignPatterns.Behavioral.Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class BlackWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black and White!");
        }
    }
}
