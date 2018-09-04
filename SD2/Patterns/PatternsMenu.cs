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
            Printer.PrintLine("PATTERNS MENU");
        }

        protected override void PrintMenuBody()
        {
            const string underConstruction = Constants.Menu.UnderConstruction;

            Printer.PrintLine($" {(int)PatternsMenuOptions.FactoryMethod}: Factory Method");
            Printer.PrintLine($" {(int)PatternsMenuOptions.Singleton}: Singleton");
            Printer.PrintLine($" {(int)PatternsMenuOptions.Adapter}: Adapter");
            Printer.PrintLine($" {(int)PatternsMenuOptions.Composite}: Composite");
            Printer.PrintLine($" {(int)PatternsMenuOptions.Decorator}: Decorator");
            Printer.PrintLine($" {(int)PatternsMenuOptions.Command}: Command");
            Printer.PrintLine($" {(int)PatternsMenuOptions.ChainOfResponsiblity}: Chain of Responsibility");
            Printer.PrintLine($" {(int)PatternsMenuOptions.Mediator}: Mediator {underConstruction}");
            Printer.PrintLine($" {(int)PatternsMenuOptions.Observer}: Observer {underConstruction}");
            Printer.PrintLine($"{(int)PatternsMenuOptions.Strategy}: Strategy {underConstruction}");
            Printer.PrintLine($"{(int)PatternsMenuOptions.TemplateMehtod}: Template Method {underConstruction}");
            Printer.PrintLine($"{(int)PatternsMenuOptions.Visitor}: Visitor {underConstruction}");
            Printer.PrintLine($"{(int)PatternsMenuOptions.Builder}: Builder");
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
                case PatternsMenuOptions.Decorator: Decorator.UserInputValidationDecorators.Run.Operation(); break;
                case PatternsMenuOptions.Command: Command.Run.Operation(); break;
                case PatternsMenuOptions.ChainOfResponsiblity: ChainOfResponsibility.Run.Operation(); break;
                case PatternsMenuOptions.Mediator: Printer.PrintLine(underConstruction); break;
                case PatternsMenuOptions.Observer: Printer.PrintLine(underConstruction); break;
                case PatternsMenuOptions.Strategy: Printer.PrintLine(underConstruction); break;
                case PatternsMenuOptions.TemplateMehtod: Printer.PrintLine(underConstruction); break;
                case PatternsMenuOptions.Visitor: Printer.PrintLine(underConstruction); break;
                case PatternsMenuOptions.Builder: Builder.Run.Operation(); break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
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
