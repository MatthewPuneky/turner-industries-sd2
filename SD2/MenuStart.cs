using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;

namespace SD2
{
    public class ApplicationMainMenu : Menu
    {
        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(ApplicationMainMenuOptions));
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("APPLICATION MAIN MENU");
        }

        protected override void PrintMenuBody()
        {
            const string underConstruction = Constants.Menu.UnderConstruction;

            Printer.PrintLine($"{(int)ApplicationMainMenuOptions.General}: General {underConstruction}");
            Printer.PrintLine($"{(int)ApplicationMainMenuOptions.Backend}: Backend {underConstruction}");
            Printer.PrintLine($"{(int)ApplicationMainMenuOptions.Patterns}: Patterns ");
            Printer.PrintLine($"{(int)ApplicationMainMenuOptions.SolidPrincipals}: Solid Principals {underConstruction}");
            Printer.PrintLine($"{(int)ApplicationMainMenuOptions.TSql}: T-Sql {underConstruction}");
            Printer.PrintLine($"{(int)ApplicationMainMenuOptions.DevOps}: DevOps {underConstruction}");
        }

        protected override void MenuOptions(string userInput)
        {
            const string underConstruction = Constants.Menu.UnderConstructionToUserResponse;
            var option = (ApplicationMainMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case ApplicationMainMenuOptions.General: Printer.PrintLine(underConstruction); break;
                case ApplicationMainMenuOptions.Backend: Printer.PrintLine(underConstruction); break;
                case ApplicationMainMenuOptions.Patterns: MenuFactory.PatternsMenu().Display(); break;
                case ApplicationMainMenuOptions.SolidPrincipals: Printer.PrintLine(underConstruction); break;
                case ApplicationMainMenuOptions.TSql: Printer.PrintLine(underConstruction); break;
                case ApplicationMainMenuOptions.DevOps: Printer.PrintLine(underConstruction); break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum ApplicationMainMenuOptions
    {
        General = 1,
        Backend,
        Patterns,
        SolidPrincipals,
        TSql,
        DevOps,
        Foo
    }
}
