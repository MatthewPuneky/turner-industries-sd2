using System;

namespace SD2.Patterns
{
    public static class Menu
    {
        private const int FactoryMethodId = 1;
        private const int SingletonId = 2;
        private const int AdapterId = 3;
        private const int CompositeId = 4;
        private const int DecoratorId = 5;
        private const int CommandId = 6;
        private const int ChainOfResponsiblityId = 7;
        private const int MediatorId = 8;
        private const int ObserverId = 9;
        private const int StrategyId = 10;
        private const int TemplateMehtodId = 11;
        private const int VisitorId = 12;

        public static void Print()
        {
            while (true)
            {
                Console.WriteLine("PATTERNS MENU");
                Console.WriteLine($" {FactoryMethodId}: Factory Method");
                Console.WriteLine($" {SingletonId}: Singleton");
                Console.WriteLine($" {AdapterId}: Adapter");
                Console.WriteLine($" {CompositeId}: Composite");
                Console.WriteLine($" {DecoratorId}: Decorator");
                Console.WriteLine($" {CommandId}: Command");
                Console.WriteLine($" {ChainOfResponsiblityId}: Chain of Responsibility");
                Console.WriteLine($" {MediatorId}: Mediator");
                Console.WriteLine($" {ObserverId}: Observer");
                Console.WriteLine($"{StrategyId}: Strategy");
                Console.WriteLine($"{TemplateMehtodId}: Template Method");
                Console.WriteLine($"{VisitorId}: Visitor");

                Console.Write("Select an option (0 to exit): ");
                var userInput = Console.ReadLine();
                Console.WriteLine();

                var wasParseable = int.TryParse(userInput, out var option);
                if (!wasParseable) continue;

                if (option == 0) break;

                switch (option)
                {
                    case FactoryMethodId: Console.WriteLine("Under construction\n"); break;
                    case SingletonId: Console.WriteLine("Under construction\n"); break;
                    case AdapterId: Console.WriteLine("Under construction\n"); break;
                    case CompositeId: Console.WriteLine("Under construction\n"); break;
                    case DecoratorId: Console.WriteLine("Under construction\n"); break;
                    case CommandId: Console.WriteLine("Under construction\n"); break;
                    case ChainOfResponsiblityId: ChainOfResponsibility.Run.Operation(); break;
                    case MediatorId: Console.WriteLine("Under construction\n"); break;
                    case ObserverId: Console.WriteLine("Under construction\n"); break;
                    case StrategyId: Console.WriteLine("Under construction\n"); break;
                    case TemplateMehtodId: Console.WriteLine("Under construction\n"); break;
                    case VisitorId: Console.WriteLine("Under construction\n"); break;
                    default: Console.WriteLine("INVALID OPTION\n"); break;
                }
            }
        }
    }
}
