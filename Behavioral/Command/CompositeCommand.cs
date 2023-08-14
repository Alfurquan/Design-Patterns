using DesignPatterns.Behavioral.Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class CompositeCommand : ICommand
    {
        List<ICommand> commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in commands)
                command.Execute();
        }
    }
}
