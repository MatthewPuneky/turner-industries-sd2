using System.Linq;
using SD2.Patterns.Command.State;
using SD2.Patterns.Command.UndoOptions;
using static SD2.SharedFeatures.Helpers.ObjectHelpers;

namespace SD2.Patterns.Command.UndoTakeoffOperations
{
    public class DeleteTakeoff : UndoableCommand<Takeoff>
    {
        private Takeoff _previousState;

        public DeleteTakeoff(int id)
        {
            var state = UndoableCommandState.Instance;

            var takeoff = state.Takeoffs.First(x => x.Id == id);
            _previousState = DeepClone(takeoff);
        }

        public override Takeoff Execute()
        {
            var state = UndoableCommandState.Instance;

            var takeoffToRemove = state.Takeoffs.First(x => x.Id == _previousState.Id);
            UndoableCommandState.Instance.Takeoffs.Remove(takeoffToRemove);

            return null;
        }

        public override Takeoff Undo()
        {
            var state = UndoableCommandState.Instance;

            state.Takeoffs.Add(_previousState);
            var takeoffToReturn = state.Takeoffs.First(x => x.Id == _previousState.Id);

            return takeoffToReturn;
        }
    }
}
