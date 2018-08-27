using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.IntegerValidators
{
    public class LessThanOrEqualTo : AbstractValidator<int>
    {
        private readonly int _valueShouldBeLessThan;

        public LessThanOrEqualTo(int valueShouldBeLessThan)
        {
            _valueShouldBeLessThan = valueShouldBeLessThan;
        }

        public override bool Validate(int itemToValidate)
        {
            var validationState = itemToValidate < _valueShouldBeLessThan;

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} was not less than {_valueShouldBeLessThan}");
            }

            return validationState;
        }
    }
}
