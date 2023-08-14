using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Editor
{
    public class History
    {
        private Stack<IUndoableCommand> commands  = new Stack<IUndoableCommand>();
        public int Size()
        {  
            return commands.Count; 
        } 
        public void Push(IUndoableCommand command)
        {
            commands.Push(command);
        }

        public IUndoableCommand Pop()
        {

            return commands.Pop();
        }
    }
}
