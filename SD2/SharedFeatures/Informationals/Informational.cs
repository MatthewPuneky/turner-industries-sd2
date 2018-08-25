using SD2.SharedFeatures.Helpers;
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

        private string HowToExitPagedMenu()
        {
            return "[E]xit";
        }

        private string HowToContinune()
        {
            return "[N]ext";
        }

        protected virtual string InformUserOfEndOfList()
        {
            return "End of information";
        }

        public void Display()
        {
            foreach(var line in LoadLinesToDisplay())
            {
                Console.WriteLine(line);

                if(DisplayInformationPaged)
                {
                    LinesDisplayed++;

                    if(LinesDisplayed > LinesPerPage)
                    {
                        if (GetValidInputFromUser() == InformationalOptions.Exit)
                        {
                            Console.WriteLine();
                            return;
                        }

                        LinesDisplayed = 1;
                    }
                }
            }

            Salutation();
        }

        private void Salutation()
        {
            Console.Write($"{InformUserOfEndOfList()} - [ENTER] to exit: ");
            Console.ReadLine();
            
            ConsoleHelpers.ClearPreviousLine();
        }

        private InformationalOptions GetValidInputFromUser()
        {
            var userInputIsInvalid = true;
            InformationalOptions valueToReturn = InformationalOptions.NextPage;

            while (userInputIsInvalid)
            {
                userInputIsInvalid = false;
                Console.Write($"{HowToContinune()} - {HowToExitPagedMenu()}: ");
                var userInput = Console.ReadLine();

                switch(userInput.ToUpper())
                {
                    case "":
                    case "N":
                    case "NEXT": valueToReturn = InformationalOptions.NextPage; break;
                    case "E":
                    case "EXIT": valueToReturn = InformationalOptions.Exit; break;
                    default: userInputIsInvalid = true; break;
                }
                
                ConsoleHelpers.ClearPreviousLine();
            }

            return valueToReturn;
        }
    }

    public abstract class Informational<T> : Informational
    {
        protected T State;

        public Informational(T state)
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
