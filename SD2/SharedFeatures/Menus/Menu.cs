using System;
using System.Collections.Generic;
using System.Linq;

namespace SD2.SharedFeatures.Menus
{
    public abstract class Menu
    {
        protected virtual List<string> LegalValues => new List<string>();
        protected virtual List<string> IllegalVales => new List<string>();
        protected virtual bool AllInputLegal => false;

        protected virtual bool CanExit => false;

        protected abstract void PrintMenuHeader();
        protected abstract void PrintMenuBody();
        protected abstract void MenuOptions(string userInput);

        protected bool MenuIsActive { get; set; } = true;

        protected virtual void PrintUserInputPrompt()
        {
            if(CanExit)
            {
                Console.Write($"Select an option (0 to exit): ");
            }
            else
            {
                Console.Write("Select an option: ");
            }
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

                if (CanExit && userInput == "0")
                {
                    break;
                }

                MenuOptions(userInput);
            }

            Console.WriteLine();
        }

        private bool IsUserInputValid(string input)
        {
            var result = true;

            if (AllInputLegal) return true;
            if (CanExit && input == "0") return true;

            var isNotLegalInput = LegalValues != null && LegalValues.Any() && !LegalValues.Contains(input);
            var isIllegalInput = IllegalVales != null && IllegalVales.Any() && IllegalVales.Contains(input);

            if (isNotLegalInput) result = false;
            if (isIllegalInput) result = false;

            return result;
        }
    }

    public abstract class Menu<T> : Menu
    {
        protected T State;

        public Menu(T state)
        {
            State = state;
        }
    }
}
