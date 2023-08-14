using DesignPatterns.Behavioral.Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Editor
{
    public class UndoCommand : ICommand
    {
        private History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if(history.Size() > 0)
            history.Pop().Unexecute();
        }
    }
}
