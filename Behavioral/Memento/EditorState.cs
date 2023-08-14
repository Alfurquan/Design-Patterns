using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class EditorState
    {
        public string Content { get; set; }

        public EditorState(string content)
        {
            Content = content;
        }
    }
}
