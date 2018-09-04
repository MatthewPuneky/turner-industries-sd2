using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Decorator.UserInputValidationDecorators.UserInputs;
using SD2.Patterns.Decorator.UserInputValidationDecorators.UserInputValidators.StringValidators;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Decorator.UserInputValidationDecorators
{
    public static class Run
    {
        public static void Operation()
        {
            var userInput = new BasicUserInput();
            var validated1 = new UserInputContainsValueValidator("Foo");
            var validated2 = new UserInputContainsValueValidator("Bar");

            validated1.SetUserInput(userInput);
            validated2.SetUserInput(validated1);

            var whatever = validated2.GetUserInput();

            foreach (var error in validated2.ErrorMessages)
            {
                Printer.PrintLine(error);
            }

            foreach (var error in validated1.ErrorMessages)
            {
                Printer.PrintLine(error);
            }
        }
    }
}
