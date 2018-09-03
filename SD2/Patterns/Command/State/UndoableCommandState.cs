using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Command.UndoTakeoffOperations;

namespace SD2.Patterns.Command.State
{
    public class UndoableCommandState
    {
        private UndoableCommandState() { }
        private static UndoableCommandState _instance;
        public static UndoableCommandState Instance => _instance ?? (_instance = new UndoableCommandState());

        public List<Takeoff> Takeoffs = new List<Takeoff>();
    }
}
