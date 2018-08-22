using System;
using System.Collections.Generic;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Common.Menus
{
    public abstract class Menu
    {
        protected abstract List<string> LegalValues { get; }
        protected abstract bool CanExit { get; }

        protected abstract void PrintMenuHeader();
        protected abstract void PrintMenuBody();

        protected virtual void PrintUserInputPrompt()
        {
            Console.Write("Select an option: ");
        }

        protected string GetUserInput()
        {
            while (true)
            {
                PrintUserInputPrompt();
                var input = Console.ReadLine();

                if (IsUserInputValid(input))
                {
                    return input;
                }

                Console.WriteLine("INVALID INPUT");
            }
        }

        protected virtual string PrintMenuWithUserInput()
        {
            PrintMenuHeader();
            PrintMenuBody();
            return GetUserInput();
        }

        public abstract void HandleMenu();

        private bool IsUserInputValid(string input)
        {
            return LegalValues.Contains(input);
        }
    }
}
