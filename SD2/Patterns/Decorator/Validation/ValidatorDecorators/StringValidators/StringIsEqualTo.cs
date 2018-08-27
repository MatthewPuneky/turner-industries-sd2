using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.StringValidators
{
    public class StringIsEqualTo : AbstractValidator<string>
    {
        private readonly string _valueShouldBe;

        public StringIsEqualTo(string valueShouldBe)
        {
            _valueShouldBe = valueShouldBe;
        }
        
        public override bool Validate(string itemToValidate)
        {
            var validationState = itemToValidate.Equals(_valueShouldBe);

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} did not equal {_valueShouldBe}");
            }

            return validationState;
        }
    }
}
