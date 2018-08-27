using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.StringValidators
{
    public class StringIsNotEqualTo : AbstractValidator<string>
    {
        private readonly string _valueShouldNotBe;

        public StringIsNotEqualTo(string valueShouldNotBe)
        {
            _valueShouldNotBe = valueShouldNotBe;
        }

        public override bool Validate(string itemToValidate)
        {
            var validationState = !itemToValidate.Equals(_valueShouldNotBe);

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} equaled the sent in value of {_valueShouldNotBe}");
            }

            return validationState;
        }
    }
}
