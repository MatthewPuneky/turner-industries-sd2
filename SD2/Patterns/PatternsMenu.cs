using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns
{
    public class PatternsMenu : Menu
    {
        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(PatternsMenuOptions));
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.WriteLine("PATTERNS MENU");
        }

        protected override void PrintMenuBody()
        {
            const string underConstruction = Constants.Menu.UnderConstruction;

            Printer.WriteLine($" {(int)PatternsMenuOptions.FactoryMethod}: Factory Method");
            Printer.WriteLine($" {(int)PatternsMenuOptions.Singleton}: Singleton");
            Printer.WriteLine($" {(int)PatternsMenuOptions.Adapter}: Adapter");
            Printer.WriteLine($" {(int)PatternsMenuOptions.Composite}: Composite");
            Printer.WriteLine($" {(int)PatternsMenuOptions.Decorator}: Decorator {underConstruction}");
            Printer.WriteLine($" {(int)PatternsMenuOptions.Command}: Command {underConstruction}");
            Printer.WriteLine($" {(int)PatternsMenuOptions.ChainOfResponsiblity}: Chain of Responsibility");
            Printer.WriteLine($" {(int)PatternsMenuOptions.Mediator}: Mediator {underConstruction}");
            Printer.WriteLine($" {(int)PatternsMenuOptions.Observer}: Observer {underConstruction}");
            Printer.WriteLine($"{(int)PatternsMenuOptions.Strategy}: Strategy {underConstruction}");
            Printer.WriteLine($"{(int)PatternsMenuOptions.TemplateMehtod}: Template Method {underConstruction}");
            Printer.WriteLine($"{(int)PatternsMenuOptions.Visitor}: Visitor {underConstruction}");
            Printer.WriteLine($"{(int)PatternsMenuOptions.Builder}: Builder");
        }

        protected override void MenuOptions(string userInput)
        {
            const string underConstruction = Constants.Menu.UnderConstructionToUserResponse;
            var option = (PatternsMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case PatternsMenuOptions.FactoryMethod: FactoryMethod.DungeonHunter.Game.GameLoop.Start(); break;
                case PatternsMenuOptions.Singleton: Singleton.State.Run.Operation(); break;
                case PatternsMenuOptions.Adapter: Adapter.LegacyBankAdapter.Run.Operation(); break;
                case PatternsMenuOptions.Composite: Composite.Tree.Run.Operation(); break;
                case PatternsMenuOptions.Decorator: Printer.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Command: Printer.WriteLine(underConstruction); break;
                case PatternsMenuOptions.ChainOfResponsiblity: ChainOfResponsibility.Run.Operation(); break;
                case PatternsMenuOptions.Mediator: Printer.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Observer: Printer.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Strategy: Printer.WriteLine(underConstruction); break;
                case PatternsMenuOptions.TemplateMehtod: Printer.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Visitor: Printer.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Builder: Builder.Run.Operation(); break;
                default:
                    Printer.WriteLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }
        }
    }

    public enum PatternsMenuOptions
    {
        FactoryMethod = 1,
        Singleton,
        Adapter,
        Composite,
        Decorator,
        Command,
        ChainOfResponsiblity,
        Mediator,
        Observer,
        Strategy,
        TemplateMehtod,
        Visitor,
        Builder,
    }
}
