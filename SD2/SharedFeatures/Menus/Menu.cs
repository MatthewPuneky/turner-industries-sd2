using System;
using System.Collections.Generic;

namespace SD2.SharedFeatures.Menus
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

        public virtual string PrintMenuWithUserInput()
        {
            PrintMenuHeader();
            PrintMenuBody();
            return GetUserInput();
        }

        private bool IsUserInputValid(string input)
        {
            return LegalValues.Contains(input);
        }
    }

    public abstract class MenuHandler
    {
        public Menu Menu { get; }

        protected abstract void MenuOptions(string userInput);
        protected bool MenuIsActive { get; set; } = true;

        protected MenuHandler(Menu menu)
        {
            Menu = menu;
        }

        public void HandleMenu()
        {
            Console.WriteLine();

            while (MenuIsActive)
            {
                var userInput = Menu.PrintMenuWithUserInput();

                MenuOptions(userInput);

            }

            Console.WriteLine();
        }
    }

    public abstract class MenuHandler<T>
    {
        protected Menu Menu { get; }
        protected T State { get; }

        protected abstract void MenuOptions(string userInput);
        protected bool MenuIsActive { get; set; } = true;

        protected MenuHandler(Menu menu, T state)
        {
            State = state;
            Menu = menu;
        }

        public void HandleMenu()
        {
            Console.WriteLine();

            while (MenuIsActive)
            {
                var userInput = Menu.PrintMenuWithUserInput();

                MenuOptions(userInput);
            }

            Console.WriteLine();
        }
    }
}
