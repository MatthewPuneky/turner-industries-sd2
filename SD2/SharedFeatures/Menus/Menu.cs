using SD2.SharedFeatures.Printers;
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
                Printer.Write($"Select an option (0 to exit): ");
            }
            else
            {
                Printer.Write("Select an option: ");
            }
        }

        protected string GetUserInput()
        {
            while (true)
            {
                PrintUserInputPrompt();
                var input = Printer.ReadLine();

                if (IsUserInputValid(input))
                {
                    return input;
                }

                Printer.WriteLine("INVALID INPUT");
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
            Printer.WriteLine();

            while (MenuIsActive)
            {
                var userInput = PrintMenuWithUserInput();

                if (CanExit && userInput == "0")
                {
                    break;
                }

                MenuOptions(userInput);
            }

            Printer.WriteLine();
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
