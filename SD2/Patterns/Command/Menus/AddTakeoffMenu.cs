using System.Collections.Generic;
using SD2.Patterns.Command.State;
using SD2.Patterns.Command.UndoTakeoffOperations;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Command.Menus
{
    public class AddTakeoffMenu : Menu
    {
        private TakeoffDto _takeoffToAdd = new TakeoffDto();

        protected override bool CanExit => true;
        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(AddTakeoffOptions));

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("ADD TAKEOFF MENU");
        }

        protected override void PrintMenuBody()
        {
            var curDrawingNumber = _takeoffToAdd.DrawingNumber ?? "Unset";

            var curAbbreviation = _takeoffToAdd.Abbreviation ?? "Unset";

            var curSize =
                _takeoffToAdd.Size == 0
                    ? "Unset"
                    : _takeoffToAdd.Size.ToString();

            Printer.PrintLine($"{(int)AddTakeoffOptions.SetDrawingNumber}: Set Drawing Number ({curDrawingNumber})");
            Printer.PrintLine($"{(int)AddTakeoffOptions.SetAbbreviation}: Set Abbreviation ({curAbbreviation})");
            Printer.PrintLine($"{(int)AddTakeoffOptions.SetSize}: Set Size ({curSize})");
            Printer.PrintLine($"{(int)AddTakeoffOptions.SaveTakeoff}: Save Takeoff");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (AddTakeoffOptions)int.Parse(userInput);

            switch (option)
            {
                case AddTakeoffOptions.SetDrawingNumber: CommandTakeoffMenuFactory.SetDrawingNumberMenu(_takeoffToAdd).Display(); break;
                case AddTakeoffOptions.SetAbbreviation: CommandTakeoffMenuFactory.SetAbbreviationMenu(_takeoffToAdd).Display(); break;
                case AddTakeoffOptions.SetSize: CommandTakeoffMenuFactory.SetSizeMenu(_takeoffToAdd).Display(); break;
                case AddTakeoffOptions.SaveTakeoff:
                    var addTakeoffCommand = new AddTakeoffCommand(_takeoffToAdd);
                    UndoableCommandState.Instance.TakeoffCommandManager.ExecuteCommand(addTakeoffCommand);
                    MenuIsActive = false;
                    break;
            }
        }
    }

    public enum AddTakeoffOptions
    {
        SetDrawingNumber = 1,
        SetAbbreviation,
        SetSize,
        SaveTakeoff
    }
}
