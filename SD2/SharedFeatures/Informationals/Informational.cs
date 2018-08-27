﻿using SD2.SharedFeatures.Printers;
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
            var firstLoop = true;

            foreach(var line in LoadLinesToDisplay())
            {
                if (firstLoop)
                {
                    Printer.WriteLine();
                    firstLoop = false;
                    LinesDisplayed++;
                }

                Printer.WriteLine(line);

                if(DisplayInformationPaged)
                {
                    LinesDisplayed++;

                    if(LinesDisplayed > LinesPerPage)
                    {
                        if (GetValidInputFromUser() == InformationalOptions.Exit)
                        {
                            Printer.WriteLine();
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
            Printer.Write($"{InformUserOfEndOfList()} - [Any Key] to exit: ");
            Printer.ReadKeyChar();
            Printer.WriteLine();

            Printer.ClearPreviousLine();
        }

        private InformationalOptions GetValidInputFromUser()
        {
            var userInputIsInvalid = true;
            InformationalOptions valueToReturn = InformationalOptions.NextPage;

            while (userInputIsInvalid)
            {
                userInputIsInvalid = false;
                Printer.Write($"{HowToContinune()} - {HowToExitPagedMenu()}: ");
                var userInput = Printer.ReadLine();

                switch(userInput.ToUpper())
                {
                    case "":
                    case "N":
                    case "NEXT": valueToReturn = InformationalOptions.NextPage; break;
                    case "E":
                    case "EXIT": valueToReturn = InformationalOptions.Exit; break;
                    default: userInputIsInvalid = true; break;
                }

                Printer.ClearPreviousLine();
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
