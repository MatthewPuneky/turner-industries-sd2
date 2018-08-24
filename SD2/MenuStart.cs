using System;
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
            Console.WriteLine("APPLICATION MAIN MENU");
        }

        protected override void PrintMenuBody()
        {
            const string underConstruction = Constants.MenuConstants.UnderConstruction;

            Console.WriteLine($"{(int)ApplicationMainMenuOptions.General}: General {underConstruction}");
            Console.WriteLine($"{(int)ApplicationMainMenuOptions.Backend}: Backend {underConstruction}");
            Console.WriteLine($"{(int)ApplicationMainMenuOptions.Patterns}: Patterns ");
            Console.WriteLine($"{(int)ApplicationMainMenuOptions.SolidPrincipals}: Solid Principals {underConstruction}");
            Console.WriteLine($"{(int)ApplicationMainMenuOptions.TSql}: T-Sql {underConstruction}");
            Console.WriteLine($"{(int)ApplicationMainMenuOptions.DevOps}: DevOps {underConstruction}");
        }

        protected override void MenuOptions(string userInput)
        {
            const string underConstruction = Constants.MenuConstants.UnderConstructionToUserResponse;
            var option = (ApplicationMainMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case ApplicationMainMenuOptions.General: Console.WriteLine(underConstruction); break;
                case ApplicationMainMenuOptions.Backend: Console.WriteLine(underConstruction); break;
                case ApplicationMainMenuOptions.Patterns: MenuFactory.PatternsMenu().Display(); break;
                case ApplicationMainMenuOptions.SolidPrincipals: Console.WriteLine(underConstruction); break;
                case ApplicationMainMenuOptions.TSql: Console.WriteLine(underConstruction); break;
                case ApplicationMainMenuOptions.DevOps: Console.WriteLine(underConstruction); break;
                default:
                    Console.WriteLine(Constants.MenuConstants.FailedToHandle(option.ToString()));
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
        Poop
    }
}
