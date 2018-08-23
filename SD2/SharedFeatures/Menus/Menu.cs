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
        protected abstract void MenuOptions(string userInput);

        protected bool MenuIsActive { get; set; } = true;

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
        
        public void Display()
        {
            Console.WriteLine();

            while (MenuIsActive)
            {
                var userInput = PrintMenuWithUserInput();

                MenuOptions(userInput);
            }

            Console.WriteLine();
        }

        private bool IsUserInputValid(string input)
        {
            if (CanExit && input == "0") return true; 
            return LegalValues.Contains(input);
        }
    }

    public abstract class Menu<T> : Menu
    {
        protected T State;

        protected Menu(T state)
        {
            State = state;
        }
    }
}
