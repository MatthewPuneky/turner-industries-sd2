using System.Collections.Generic;

namespace SD2.Patterns.Decorator.UserInputValidationDecorators.UserInputValidators
{
    public abstract class UserInputWithValidationAbility : UserInput
    {
        public new UserInputRespons GetUserInput()
        {
            var userInput = base.GetUserInput();
            return new UserInputRespons{UserInput = userInput};
        }
    }

    public class UserInputRespons
    {
        public string UserInput { get; set; }
        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; }
    }


    public abstract class UserInputValidator : UserInput
    {
        private string _userInput;

        public bool IsValid { get; private set; }

        public List<string> ErrorMessages = new List<string>();
        protected UserInput UserInput;

        public void SetUserInput(UserInput userInput)
        {
            UserInput = userInput;
        }

        public override void DisplayUserInputPrompt() => UserInput.DisplayUserInputPrompt();
        public override string ReadUserInput() => UserInput.ReadUserInput();

        public override string GetUserInput()
        {
            var userInput = UserInput.GetUserInput();
            var result = GetValidatedUserInput(userInput);

            IsValid = IsValid || result.isValid;

            return userInput;
        }

        public (string userInput, bool isValid, List<string> ErrorMessages) GetValidatedUserInput(string userInput)
        {
            var isValid = ValidateUserInput(userInput);
            return (userInput, isValid, ErrorMessages);
        }

        public abstract bool ValidateUserInput(string validateAgainst);
    }
}
