using System;
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
        protected virtual InputTypes InputType => InputTypes.Any;

        protected virtual bool CanExit => false;

        protected abstract void PrintMenuHeader();
        protected abstract void PrintMenuBody();
        protected abstract void MenuOptions(string userInput);

        protected bool MenuIsActive { get; set; } = true;

        protected virtual void PrintUserInputPrompt()
        {
            if(CanExit)
            {
                Printer.Print($"Select an option (0 to exit): ");
            }
            else
            {
                Printer.Print("Select an option: ");
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

                Printer.PrintLine("INVALID INPUT");
            }
        }

        protected virtual string PrintMenuWithUserInput()
        {
            PrintMenuHeader();
            PrintMenuBody();
            return GetUserInput();
        }
        
        public virtual void Display()
        {
            Printer.Clear();

            while (MenuIsActive)
            {
                var userInput = PrintMenuWithUserInput();

                if (CanExit && userInput == "0")
                {
                    break;
                }

                MenuOptions(userInput);
            }

            Printer.Clear();
        }

        private bool IsUserInputValid(string input)
        {
            var result = true;

            if (AllInputLegal) return true;
            if (CanExit && input == "0") return true;

            var isRightType = CheckUserInputAgainstType(input);
            var isNotLegalInput = LegalValues != null && LegalValues.Any() && !LegalValues.Contains(input);
            var isIllegalInput = IllegalVales != null && IllegalVales.Any() && IllegalVales.Contains(input);

            if (!isRightType) result = false;
            if (isNotLegalInput) result = false;
            if (isIllegalInput) result = false;

            return result;
        }

        private bool CheckUserInputAgainstType(string input)
        {
            switch (InputType)
            {
                case InputTypes.Any:
                    return true;
                case InputTypes.Integer:
                    var canParse = int.TryParse(input, out var result);
                    return canParse;
                default: throw new Exception($"Input Type of {InputType} was not recognized.");
            }
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

    public abstract class Menu<TState, TResponse> : Menu<TState>
    {
        protected TResponse Response;

        protected Menu(TState state) : base(state)
        {
        }

        public new TResponse Display()
        {
            base.Display();
            return Response;
        }
    }

    public enum InputTypes
    {
        Any = 1,
        Integer
    }
}
