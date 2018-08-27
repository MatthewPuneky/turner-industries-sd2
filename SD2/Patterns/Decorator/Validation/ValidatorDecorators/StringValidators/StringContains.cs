using System.Collections.Generic;
using System.Linq;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.StringValidators
{
    public class StringContains : AbstractValidator<string>
    {
        private readonly List<string> _requiredValues = new List<string>();

        public StringContains(string requiredValue)
        {
            _requiredValues.Add(requiredValue);
        }

        public StringContains(List<string> requiredValues)
        {
            _requiredValues = requiredValues;
        }

        public override bool Validate(string itemToValidate)
        {
            var validationState = _requiredValues.All(itemToValidate.Contains);

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} did not containe value in the list sent in");
            }

            return validationState;
        }
    }
}
