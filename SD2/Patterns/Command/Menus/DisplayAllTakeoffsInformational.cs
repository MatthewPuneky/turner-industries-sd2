using System.Collections.Generic;
using System.Linq;
using SD2.Patterns.Command.State;
using SD2.SharedFeatures.Informationals;

namespace SD2.Patterns.Command.Menus
{
    public class DisplayAllTakeoffsInformational : Informational<UndoableCommandState>
    {
        public DisplayAllTakeoffsInformational() 
            : base(UndoableCommandState.Instance)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            foreach (var takeoff in State.Takeoffs.OrderBy(x => x.Id))
            {
                yield return $"Id ------------- {takeoff.Id}";
                yield return $"Drawing Number - {takeoff.DrawingNumber}";
                yield return $"Abbreviation --- {takeoff.Abbreviation}";
                yield return $"Size ----------- {takeoff.Size}";
                yield return $"Man Hours ------ {takeoff.ManHours}";
                yield return "";
            }
        }
    }
}
