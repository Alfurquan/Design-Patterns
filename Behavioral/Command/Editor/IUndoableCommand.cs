using DesignPatterns.Behavioral.Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Editor
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
