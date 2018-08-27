using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.IntegerValidators
{
    public class IntegerIsNotEqualTo : AbstractValidator<int>
    {
        private readonly int _valueShouldNotBe;

        public IntegerIsNotEqualTo(int valueShouldNotBe)
        {
            _valueShouldNotBe = valueShouldNotBe;
        }

        public override bool Validate(int itemToValidate)
        {
            var validationState = itemToValidate != _valueShouldNotBe;

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} was equal to {_valueShouldNotBe}");
            }

            return validationState;
        }
    }
}
