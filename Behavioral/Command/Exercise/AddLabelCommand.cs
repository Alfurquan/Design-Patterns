using DesignPatterns.Behavioral.Command.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Exercise
{
    public class AddLabelCommand : IUndoableCommand
    {
        private History history;
        private VideoEditor videoEditor;
        private string text;
        public AddLabelCommand(VideoEditor videoEditor, History history, string text)
        {
            this.videoEditor = videoEditor;
            this.history = history;
            this.text = text;
        }

        public void Execute()
        {
            videoEditor.SetText(text);
            history.Push(this);
        }

        public void Unexecute()
        {
            videoEditor.RemoveText();
        }
    }
}
