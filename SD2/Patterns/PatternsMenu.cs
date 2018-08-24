using System;
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
            Console.WriteLine("PATTERNS MENU");
        }

        protected override void PrintMenuBody()
        {
            const string underConstruction = Constants.MenuConstants.UnderConstruction;

            Console.WriteLine($" {(int)PatternsMenuOptions.FactoryMethod}: Factory Method");
            Console.WriteLine($" {(int)PatternsMenuOptions.Singleton}: Singleton");
            Console.WriteLine($" {(int)PatternsMenuOptions.Adapter}: Adapter {underConstruction}");
            Console.WriteLine($" {(int)PatternsMenuOptions.Composite}: Composite {underConstruction}");
            Console.WriteLine($" {(int)PatternsMenuOptions.Decorator}: Decorator {underConstruction}");
            Console.WriteLine($" {(int)PatternsMenuOptions.Command}: Command {underConstruction}");
            Console.WriteLine($" {(int)PatternsMenuOptions.ChainOfResponsiblity}: Chain of Responsibility");
            Console.WriteLine($" {(int)PatternsMenuOptions.Mediator}: Mediator {underConstruction}");
            Console.WriteLine($" {(int)PatternsMenuOptions.Observer}: Observer {underConstruction}");
            Console.WriteLine($"{(int)PatternsMenuOptions.Strategy}: Strategy {underConstruction}");
            Console.WriteLine($"{(int)PatternsMenuOptions.TemplateMehtod}: Template Method {underConstruction}");
            Console.WriteLine($"{(int)PatternsMenuOptions.Visitor}: Visitor {underConstruction}");
            Console.WriteLine($"{(int)PatternsMenuOptions.Builder}: Builder");
        }

        protected override void MenuOptions(string userInput)
        {
            const string underConstruction = Constants.MenuConstants.UnderConstructionToUserResponse;
            var option = (PatternsMenuOptions)int.Parse(userInput);

            switch (option)
            {
                case PatternsMenuOptions.FactoryMethod: FactoryMethod.DungeonHunter.Game.GameLoop.Start(); break;
                case PatternsMenuOptions.Singleton: Singleton.State.Run.Operation(); break;
                case PatternsMenuOptions.Adapter: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Composite: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Decorator: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Command: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.ChainOfResponsiblity: ChainOfResponsibility.Run.Operation(); break;
                case PatternsMenuOptions.Mediator: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Observer: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Strategy: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.TemplateMehtod: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Visitor: Console.WriteLine(underConstruction); break;
                case PatternsMenuOptions.Builder: Builder.Run.Operation(); break;
                default:
                    Console.WriteLine(Constants.MenuConstants.FailedToHandle(option.ToString()));
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
