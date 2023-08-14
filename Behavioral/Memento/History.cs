using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class History
    {
        private Stack<EditorState> States  = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            States.Push(state);
        }

        public EditorState Pop()
        {
            return States.Pop();
        }

    }
}
