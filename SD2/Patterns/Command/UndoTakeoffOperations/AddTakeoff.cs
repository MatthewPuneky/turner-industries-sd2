using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Command.UndoOptions;
using static SD2.SharedFeatures.Helpers.IntHelpers;

namespace SD2.Patterns.Command.UndoTakeoffOperations
{
    public class AddTakeoff : UndoableCommand<Takeoff>
    {
        private Takeoff _takeoffToAdd;

        public AddTakeoff(TakeoffPostDto takeoffToCreate)
        {
            _takeoffToAdd.DrawingNumber = takeoffToCreate.DrawingNumber;
            _takeoffToAdd.Abbreviation = takeoffToCreate.Abbreviation;
            _takeoffToAdd.Size = takeoffToCreate.Size;
        }

        public override Takeoff Execute()
        {

            _takeoffToAdd.Id = NextId();

            return _takeoffToAdd;
        }

        public override Takeoff Undo()
        {
            return null;
        }
    }
}
