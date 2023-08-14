using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var history = new History();
            var videoEditor = new VideoEditor();

            var addLabelCommand = new AddLabelCommand(videoEditor, history, "demo");
            addLabelCommand.Execute();

            Console.WriteLine(videoEditor.GetText());

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(videoEditor.GetText());
        }
    }
}
