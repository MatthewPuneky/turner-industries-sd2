using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Command.State;
using SD2.Patterns.Command.UndoTakeoffOperations;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;
using static SD2.SharedFeatures.Helpers.ObjectHelpers;

namespace SD2.Patterns.Command.Menus
{
    public class SelectTakeoffByIdMenu : Menu<Takeoff, Takeoff>
    {
        public SelectTakeoffByIdMenu(Takeoff state) : base(state)
        {
        }

        protected override bool CanExit => true;
        protected override InputTypes InputType => InputTypes.Integer;

        protected override List<string> LegalValues =>
            UndoableCommandState.Instance
            .Takeoffs
            .Select(x => x.Id.ToString())
            .ToList();

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("SELECT A TAKEOFF");
        }

        protected override void PrintMenuBody()
        {
        }

        protected override void PrintUserInputPrompt()
        {
            Printer.Print($"Takeoff Id (0 to exit): ");
        }

        protected override void MenuOptions(string userInput)
        {
            var takeoffId = int.Parse(userInput);
            Response = DeepClone(UndoableCommandState.Instance.Takeoffs.First(x => x.Id == takeoffId));
            MenuIsActive = false;
        }
    }
}
