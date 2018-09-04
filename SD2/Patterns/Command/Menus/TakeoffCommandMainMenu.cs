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
                    var takeoffToEdit = CommandTakeoffMenuFactory.SelectTakeoffByIdMenu(null).Display();
                    if (takeoffToEdit != null)
                    {
                        CommandTakeoffMenuFactory.EditTakeoffMenu(takeoffToEdit).Display();
                    }
                    break;
                case TakeoffCommandMainMenuOptions.DeleteTakeoff:
                    var takeoffToDelete = CommandTakeoffMenuFactory.SelectTakeoffByIdMenu(null).Display();
                    if (takeoffToDelete != null)
                    {
                        var deleteTakeoffCommand = new DeleteTakeoffCommand(takeoffToDelete.Id);
                        UndoableCommandState.Instance.TakeoffCommandManager.ExecuteCommand(deleteTakeoffCommand);
                    }
                    break;
                case TakeoffCommandMainMenuOptions.UndoLastAction:
                    TryUndo();
                    break;
            }
        }

        private static void TryUndo()
        {
            if (UndoableCommandState.Instance.TakeoffCommandManager.CanUndo())
            {
                UndoableCommandState.Instance.TakeoffCommandManager.Undo();
                MenuFactory.SimpleMessageInformational("UNDO SUCCEEDED").Display();
                return;
            }
            
            MenuFactory.SimpleMessageInformational("NO MORE OPERATIONS TO UNDO").Display();
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
