using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Command.UndoOptions
{
    public sealed class UndoOperationsState
    {
        private UndoOperationsState() { }
        private static UndoOperationsState _instance;
        public static UndoOperationsState Instance => _instance ?? (_instance = new UndoOperationsState());

       // public List<>
    }
}
