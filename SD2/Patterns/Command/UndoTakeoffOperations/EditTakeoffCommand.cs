using System.Linq;
using SD2.Patterns.Command.State;
using SD2.Patterns.Command.UndoOptions;
using static SD2.SharedFeatures.Helpers.ObjectHelpers;

namespace SD2.Patterns.Command.UndoTakeoffOperations
{
    public class EditTakeoffCommand : UndoableCommand<Takeoff>
    {
        private Takeoff _previousState;
        private TakeoffPutDto _editTakeoffState;

        public EditTakeoffCommand(TakeoffPutDto takeoffNewState)
        {
            _editTakeoffState = takeoffNewState;

            var state = UndoableCommandState.Instance;
            var takeoff = state.Takeoffs.First(x => x.Id == takeoffNewState.Id);

            _previousState = DeepClone(takeoff);
        }

        public override Takeoff Execute()
        {
            var state = UndoableCommandState.Instance;
            var takeoff = state.Takeoffs.First(x => x.Id == _previousState.Id);

            takeoff.Id = _editTakeoffState.Id;
            takeoff.DrawingNumber = _editTakeoffState.DrawingNumber;
            takeoff.Abbreviation = _editTakeoffState.Abbreviation;
            takeoff.Size = _editTakeoffState.Size;

            return takeoff;
        }

        public override Takeoff Undo()
        {
            var state = UndoableCommandState.Instance;
            var takeoff = state.Takeoffs.First(x => x.Id == _previousState.Id);

            UndoableCommandState.Instance.Takeoffs.Remove(takeoff);
            UndoableCommandState.Instance.Takeoffs.Add(_previousState);

            return _previousState;
        }
    }
}
