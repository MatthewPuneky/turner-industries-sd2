using System;
using System.Collections.Generic;
using System.Linq;

namespace SD2.Patterns.Command.UndoOptions
{
    public class CommandManager<T>
    {
        public bool CanUndo() => _undoableCommandStack.Any();
        private readonly Stack<UndoableCommand<T>> _undoableCommandStack = new Stack<UndoableCommand<T>>();
        
        public T ExecuteCommand(Command<T> command)
        {
            var result = command.Execute();
            if (command is UndoableCommand<T> undoableCommand)
            {
                _undoableCommandStack.Push(undoableCommand);
            }
            return result;
        }

        public T Undo()
        {
            if (!CanUndo()) throw new Exception("No more items to undo");

            var undoableCommand = _undoableCommandStack.Pop();
            return undoableCommand.Undo();
        }
    }
}
