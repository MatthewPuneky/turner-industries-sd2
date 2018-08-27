using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.IntegerValidators
{
    class IntegerGreatThanOrEqualTo : AbstractValidator<int>
    {
        private readonly int _valueShouldBeGreaterThanOrEqualTo;

        public IntegerGreatThanOrEqualTo(int valueShouldBeGreaterThanOrEqualTo)
        {
            _valueShouldBeGreaterThanOrEqualTo = valueShouldBeGreaterThanOrEqualTo;
        }

        public override bool Validate(int itemToValidate)
        {
            var validationState = itemToValidate >= _valueShouldBeGreaterThanOrEqualTo;

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} was not greater than or equal to to {_valueShouldBeGreaterThanOrEqualTo}");
            }

            return validationState;
        }
    }
}
