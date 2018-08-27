using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.IntegerValidators
{
    public class IntegerIsEqualTo : AbstractValidator<int>
    {
        private readonly int _valueShouldBe;

        public IntegerIsEqualTo(int valueShouldBe)
        {
            _valueShouldBe = valueShouldBe;
        }

        public override bool Validate(int itemToValidate)
        {
            var validationState = itemToValidate == _valueShouldBe;

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} was not equal to {_valueShouldBe}");
            }

            return validationState;
        }
    }
}
