using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Command.UndoOptions
{
    public abstract class Command<T>
    {
        public abstract T Execute();
    }

    public abstract class UndoableCommand<T> : Command<T>
    {
        public abstract T Undo();
    }
}
