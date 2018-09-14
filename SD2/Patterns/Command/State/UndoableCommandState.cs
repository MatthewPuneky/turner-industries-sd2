using System.Collections.Generic;
using SD2.Patterns.Command.UndoOptions;
using SD2.Patterns.Command.UndoTakeoffOperations;

namespace SD2.Patterns.Command.State
{
    public class UndoableCommandState
    {
        private UndoableCommandState() { }
        private static UndoableCommandState _instance;
        public static UndoableCommandState Instance => _instance ?? (_instance = new UndoableCommandState());

        public CommandManager<Takeoff> TakeoffCommandManager = new CommandManager<Takeoff>();

        public List<Takeoff> Takeoffs = new List<Takeoff>();
    }
}
