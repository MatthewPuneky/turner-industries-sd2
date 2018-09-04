using System.Collections.Generic;
using SD2.Patterns.Command.UndoTakeoffOperations;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Command.Menus
{
    public class SetAbbreviationMenu : Menu<TakeoffDto>
    {
        public SetAbbreviationMenu(TakeoffDto state) : base(state)
        {
        }

        protected override List<string> IllegalVales => new List<string> { "" };

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("SET ABBREVIATION NUMBER");
        }

        protected override void PrintUserInputPrompt()
        {
            Printer.Print("Abbreviation: ");
        }

        protected override void PrintMenuBody()
        {
        }

        protected override void MenuOptions(string userInput)
        {
            State.Abbreviation = userInput;
            MenuIsActive = false;
        }
    }
}
