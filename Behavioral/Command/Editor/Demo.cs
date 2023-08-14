using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Editor
{
    public class Demo
    {
        public static void Run()
        {
            var document = new HtmlDocument();
            var history = new History();
            document.Content = "Hello World";

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            Console.WriteLine(document.Content);

            UndoCommand undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(document.Content);
        }
    }
}
