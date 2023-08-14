using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Exercise
{
    public class History
    {
        private Stack<IUndoableCommand> undoableCommands = new Stack<IUndoableCommand>();

        public int Size()
        {
            return undoableCommands.Count;
        }

        public void Push(IUndoableCommand command)
        {
            undoableCommands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return undoableCommands.Pop();
        }
    }
}
