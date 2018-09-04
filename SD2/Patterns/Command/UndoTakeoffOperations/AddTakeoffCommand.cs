using System.Linq;
using SD2.Patterns.Command.State;
using SD2.Patterns.Command.UndoOptions;
using static SD2.SharedFeatures.Helpers.IntHelpers;

namespace SD2.Patterns.Command.UndoTakeoffOperations
{
    public class AddTakeoffCommand : UndoableCommand<Takeoff>
    {
        private Takeoff _takeoffToAdd = new Takeoff();

        public AddTakeoffCommand(TakeoffDto takeoffToCreate)
        {
            _takeoffToAdd.DrawingNumber = takeoffToCreate.DrawingNumber;
            _takeoffToAdd.Abbreviation = takeoffToCreate.Abbreviation;
            _takeoffToAdd.Size = takeoffToCreate.Size;
        }

        public override Takeoff Execute()
        {
            _takeoffToAdd.Id = NextId();
            UndoableCommandState.Instance.Takeoffs.Add(_takeoffToAdd);

            return _takeoffToAdd;
        }

        public override Takeoff Undo()
        {
            var takeoffToRemove = UndoableCommandState.Instance.Takeoffs.First(x => x.Id == _takeoffToAdd.Id);
            UndoableCommandState.Instance.Takeoffs.Remove(takeoffToRemove);
            return null;
        }
    }
}
