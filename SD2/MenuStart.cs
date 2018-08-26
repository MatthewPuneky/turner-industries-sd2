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
            Printer.WriteLine("APPLICATION MAIN MENU");
        }

        protected override void PrintMenuBody()
        {
            const string underConstruction = Constants.Menu.UnderConstruction;

            Printer.WriteLine($"{(int)ApplicationMainMenuOptions.General}: General {underConstruction}");
            Printer.WriteLine($"{(int)ApplicationMainMenuOptions.Backend}: Backend {underConstruction}");
            Printer.WriteLine($"{(int)ApplicationMainMenuOptions.Patterns}: Patterns ");
            Printer.WriteLine($"{(int)ApplicationMainMenuOptions.SolidPrincipals}: Solid Principals {underConstruction}");
            Printer.WriteLine($"{(int)ApplicationMainMenuOptions.TSql}: T-Sql {underConstruction}");
            Printer.WriteLine($"{(int)ApplicationMainMenuOptions.DevOps}: DevOps {underConstruction}");
        }

        protected override void MenuOptions(string userInput)
        {
            const string underConstruction = Constants.Menu.UnderConstructionToUserResponse;
            var option = (ApplicationMainMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case ApplicationMainMenuOptions.General: Printer.WriteLine(underConstruction); break;
                case ApplicationMainMenuOptions.Backend: Printer.WriteLine(underConstruction); break;
                case ApplicationMainMenuOptions.Patterns: MenuFactory.PatternsMenu().Display(); break;
                case ApplicationMainMenuOptions.SolidPrincipals: Printer.WriteLine(underConstruction); break;
                case ApplicationMainMenuOptions.TSql: Printer.WriteLine(underConstruction); break;
                case ApplicationMainMenuOptions.DevOps: Printer.WriteLine(underConstruction); break;
                default:
                    Printer.WriteLine(Constants.Menu.FailedToHandle(option.ToString()));
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
