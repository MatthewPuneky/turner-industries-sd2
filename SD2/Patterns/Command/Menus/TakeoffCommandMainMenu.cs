using System.Collections.Generic;
using SD2.Patterns.Command.State;
using SD2.Patterns.Command.UndoTakeoffOperations;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Command.Menus
{
    public class TakeoffCommandMainMenu : Menu
    {
        protected override bool CanExit => true;
        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(TakeoffCommandMainMenuOptions));

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("COMMAND EXAMPLE: TAKEOFF UNDOABLE");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)TakeoffCommandMainMenuOptions.DisplayAllTakeoffs}: Display All Takeoffs");
            Printer.PrintLine($"{(int)TakeoffCommandMainMenuOptions.AddTakeoff}: Add Takeoff");
            Printer.PrintLine($"{(int)TakeoffCommandMainMenuOptions.EditTakeoff}: Edit Takeoff");
            Printer.PrintLine($"{(int)TakeoffCommandMainMenuOptions.DeleteTakeoff}: Delete Takeoff");
            Printer.PrintLine($"{(int)TakeoffCommandMainMenuOptions.UndoLastAction}: Undo Last Action");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (TakeoffCommandMainMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case TakeoffCommandMainMenuOptions.DisplayAllTakeoffs: 
                    CommandTakeoffMenuFactory.DisplayAllTakeoffsInformational.Display();
                    break;
                case TakeoffCommandMainMenuOptions.AddTakeoff:
                    CommandTakeoffMenuFactory.AddTakeoffMenu.Display();
                    break;
                case TakeoffCommandMainMenuOptions.EditTakeoff:
                    var takeoff = CommandTakeoffMenuFactory.SelectTakeoffByIdMenu(null).Display();
                    if (takeoff != null)
                    {
                        CommandTakeoffMenuFactory.EditTakeoffMenu(takeoff).Display();
                    }
                    break;
                case TakeoffCommandMainMenuOptions.DeleteTakeoff: 
                    Printer.PrintLine(Constants.Menu.UnderConstructionToUserResponse);
                    break;
                case TakeoffCommandMainMenuOptions.UndoLastAction:
                    if (UndoableCommandState.Instance.TakeoffCommandManager.CanUndo())
                    {
                        UndoableCommandState.Instance.TakeoffCommandManager.Undo();
                    }
                    Printer.Clear();
                    break;
            }
        }
    }

    public enum TakeoffCommandMainMenuOptions
    {
        DisplayAllTakeoffs = 1,
        AddTakeoff,
        EditTakeoff,
        DeleteTakeoff,
        UndoLastAction
    }
}
