using System;
using SD2.Patterns.Decorator.Validation.ValidatorDecorators.StringValidators;
using SD2.Patterns.Decorator.Validation.Vlaidators;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Decorator.Validation
{
    public static class Run
    {
        public static void Operation()
        {
            var validator = new Validator<string>();
            validator.Validators.Add(new StringIsNotEqualTo("FooBar"));
            validator.Validators.Add(new StringContains("Bar"));

            var userInput = Console.ReadLine();
            validator.Validate(userInput);

            foreach (var error in validator.ErrorMessages)
            {
                Printer.PrintLine(error);
            }

        }
    }
}
