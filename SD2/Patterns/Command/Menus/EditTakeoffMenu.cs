using System.Collections.Generic;
using SD2.Patterns.Command.State;
using SD2.Patterns.Command.UndoTakeoffOperations;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Command.Menus
{
    public class EditTakeoffMenu : Menu<TakeoffPutDto>
    {
        public EditTakeoffMenu(TakeoffPutDto state) : base(state)
        {
        }

        protected override bool CanExit => true;
        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(EditTakeoffOptions));

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("EDIT TAKEOFF MENU");
        }

        protected override void PrintMenuBody()
        {
            var curDrawingNumber =
                State.DrawingNumber == ""
                    ? "Unset"
                    : State.DrawingNumber;

            var curAbbreviation =
                State.Abbreviation == ""
                    ? "Unset"
                    : State.Abbreviation;

            var curSize =
                State.Size == 0
                    ? "Unset"
                    : State.Size.ToString();

            Printer.PrintLine($"{(int)EditTakeoffOptions.SetDrawingNumber}: Set Drwaing Number ({curDrawingNumber})");
            Printer.PrintLine($"{(int)EditTakeoffOptions.SetAbbreviation}: Set Abbreviation ({curAbbreviation})");
            Printer.PrintLine($"{(int)EditTakeoffOptions.SetSize}: Set Size ({curSize})");
            Printer.PrintLine($"{(int)EditTakeoffOptions.SaveTakeoff}: Save Takeoff");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (EditTakeoffOptions)int.Parse(userInput);

            switch (option)
            {
                case EditTakeoffOptions.SetDrawingNumber: CommandTakeoffMenuFactory.SetDrawingNumberMenu(State).Display(); break;
                case EditTakeoffOptions.SetAbbreviation: CommandTakeoffMenuFactory.SetAbbreviationMenu(State).Display(); break;
                case EditTakeoffOptions.SetSize: CommandTakeoffMenuFactory.SetSizeMenu(State).Display(); break;
                case EditTakeoffOptions.SaveTakeoff:
                    var addTakeoffCommand = new EditTakeoffCommand(State);
                    UndoableCommandState.Instance.TakeoffCommandManager.ExecuteCommand(addTakeoffCommand);
                    MenuIsActive = false;
                    break;
            }
        }
    }

    public enum EditTakeoffOptions
    {
        SetDrawingNumber = 1,
        SetAbbreviation,
        SetSize,
        SaveTakeoff
    }
}
