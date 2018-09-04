using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Decorator.UserInputValidationDecorators.UserInputs
{
    public class BasicUserInput : UserInput
    {
        public override void DisplayUserInputPrompt()
        {
            Printer.Write("Enter a value: ");
        }

        public override string ReadUserInput()
        {
            return Printer.ReadLine();
        }
    }
}
