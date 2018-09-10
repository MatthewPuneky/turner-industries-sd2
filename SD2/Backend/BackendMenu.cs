using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Backend
{
    public class BackendMenu : Menu
    {
        protected override bool CanExit => true;

        protected override List<string> LegalValues =>
            EnumHelper.PoistionValuesToStringList(typeof(BackendMenuOptions));

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("BACKEND MENU");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)BackendMenuOptions.Async}: Async Await");
        }

        protected override void MenuOptions(string userInput)
        {
            var option = (BackendMenuOptions) int.Parse(userInput);

            switch (option)
            {
                case BackendMenuOptions.Async: AsyncAwait.GeneralPractice.Run.Operation(); break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum BackendMenuOptions
    {
        Async = 1
    }
}
