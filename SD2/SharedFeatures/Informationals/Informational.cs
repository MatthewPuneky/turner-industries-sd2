using SD2.SharedFeatures.Printers;
using System;
using System.Collections.Generic;

namespace SD2.SharedFeatures.Informationals
{
    public abstract class Informational
    {
        protected virtual int LinesDisplayed { get; private set; } = 1;
        protected virtual bool DisplayInformationPaged => true;
        protected virtual int LinesPerPage => Console.WindowHeight;
        
        protected abstract IEnumerable<string> LoadLinesToDisplay();

        private static string HowToExitPagedMenu()
        {
            return "[E]xit";
        }

        private static string HowToContinune()
        {
            return "[N]ext or [Enter]";
        }

        protected virtual string InformUserOfEndOfList()
        {
            return "End of information";
        }

        public void Display()
        {
            Printer.Clear();
            
            foreach(var line in LoadLinesToDisplay())
            {
                Printer.PrintLine(line);

                if(DisplayInformationPaged)
                {
                    LinesDisplayed++;

                    if(LinesDisplayed >= LinesPerPage)
                    {
                        if (GetValidInputFromUser() == InformationalOptions.Exit)
                        {
                            Printer.PrintLine();
                            return;
                        }

                        LinesDisplayed = 1;
                    }
                }
            }

            Salutation();

            Printer.Clear();
        }

        private void Salutation()
        {
            Printer.Print($"{InformUserOfEndOfList()} - [Any Key] to exit: ");
            Printer.ReadKeyChar();
            Printer.PrintLine();

            Printer.ClearPreviousLine();
        }

        private InformationalOptions GetValidInputFromUser()
        {
            var userInputIsInvalid = true;
            InformationalOptions valueToReturn = InformationalOptions.NextPage;

            while (userInputIsInvalid)
            {
                userInputIsInvalid = false;
                Printer.Print($"{HowToContinune()} - {HowToExitPagedMenu()}: ");
                var userInput = Printer.ReadKeyChar();

                switch(userInput)
                {
                    case '\r':
                    case 'n':
                    case 'N': valueToReturn = InformationalOptions.NextPage; break;
                    case 'e':
                    case 'E': valueToReturn = InformationalOptions.Exit; break;
                    default: userInputIsInvalid = true; continue;
                }

                Printer.ClearCurrentConsoleLine();
            }

            return valueToReturn;
        }
    }

    public abstract class Informational<T> : Informational
    {
        protected T State;

        protected Informational(T state)
        {
            State = state;
        }
    }

    public enum InformationalOptions
    {
        NextPage,
        Exit
    }
}
