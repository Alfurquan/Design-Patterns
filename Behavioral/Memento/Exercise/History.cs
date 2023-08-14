using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.Exercise
{
    public class History
    {
        public Stack<DocumentState> DocumentStates { get; set; } = new Stack<DocumentState>();

        public void Push(DocumentState state)
        {
            DocumentStates.Push(state);
        }

        public DocumentState Pop()
        {
            return DocumentStates.Pop();
        }
    }
}
