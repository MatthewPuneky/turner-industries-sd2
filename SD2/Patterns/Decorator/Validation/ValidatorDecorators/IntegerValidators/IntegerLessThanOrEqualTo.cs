using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.IntegerValidators
{
    public class IntegerLessThanOrEqualTo : AbstractValidator<int>
    {
        private readonly int _valueShouldBeLessThanOrEqualTo;

        public IntegerLessThanOrEqualTo(int valueShouldBeLessThanOrEqualTo)
        {
            _valueShouldBeLessThanOrEqualTo = valueShouldBeLessThanOrEqualTo;
        }

        public override bool Validate(int itemToValidate)
        {
            var validationState = itemToValidate <= _valueShouldBeLessThanOrEqualTo;

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} was not less than or equal to to {_valueShouldBeLessThanOrEqualTo}");
            }

            return validationState;
        }
    }
}
