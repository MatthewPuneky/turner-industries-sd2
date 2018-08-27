using System.Collections.Generic;
using System.Linq;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.StringValidators
{
    public class StringDoesNotContain : AbstractValidator<string>
    {
        private readonly List<string> _illegalValues = new List<string>();

        public StringDoesNotContain(string illegalValue)
        {
            _illegalValues.Add(illegalValue);
        }

        public StringDoesNotContain(List<string> illegalValues)
        {
            _illegalValues = illegalValues;
        }

        public override bool Validate(string itemToValidate)
        {
            var validationState = _illegalValues.All(x => !itemToValidate.Contains(x));

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} contained a value in the list sent in");
            }

            return validationState;
        }
    }
}
