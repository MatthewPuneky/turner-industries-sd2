using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.IntegerValidators
{
    public class IntegerGreaterThan : AbstractValidator<int>
    {
        private readonly int _valueShouldBeGreaterThan;

        public IntegerGreaterThan(int valueShouldBeGreaterThan)
        {
            _valueShouldBeGreaterThan = valueShouldBeGreaterThan;
        }

        public override bool Validate(int itemToValidate)
        {
            var validationState = itemToValidate > _valueShouldBeGreaterThan;

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} was not greater than {_valueShouldBeGreaterThan}");
            }

            return validationState;
        }
    }
}
