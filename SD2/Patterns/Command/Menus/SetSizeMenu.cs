using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Command.UndoTakeoffOperations;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Command.Menus
{
    public class SetSizeMenu : Menu<TakeoffDto>
    {
        public SetSizeMenu(TakeoffDto state) : base(state)
        {
        }

        protected override List<string> IllegalVales => new List<string> { "" };
        protected override InputTypes InputType => InputTypes.Integer;

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("SET DRAWING NUMBER");
        }

        protected override void PrintUserInputPrompt()
        {
            Printer.Print("Size: ");
        }

        protected override void PrintMenuBody()
        {
        }

        protected override void MenuOptions(string userInput)
        {
            var inputAsInt = int.Parse(userInput);

            State.Size = inputAsInt;
            MenuIsActive = false;
        }
    }
}
