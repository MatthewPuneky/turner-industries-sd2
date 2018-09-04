using System.Collections.Generic;

namespace SD2.Patterns.Decorator.UserInputValidationDecorators.UserInputValidators.StringValidators
{
    public class UserInputContainsValueValidator : UserInputValidator
    {
        private readonly string _shouldContain;

        public UserInputContainsValueValidator(string shouldContain)
        {
            _shouldContain = shouldContain;
        }

        public override bool ValidateUserInput(string validateAgainst)
        {
            if (!validateAgainst.Contains(_shouldContain))
            {
                ErrorMessages.Add($"{validateAgainst} did not contain {_shouldContain}");
                return false;
            }

            return true;
        }
    }
}
