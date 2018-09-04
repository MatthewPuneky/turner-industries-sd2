using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Decorator.UserInputValidationDecorators
{
    public abstract class UserInput
    {
        public abstract void DisplayUserInputPrompt();
        public abstract string ReadUserInput();

        public virtual string GetUserInput()
        {
            DisplayUserInputPrompt();
            return ReadUserInput();
        }
    }
}
