using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Decorator.Validation.ValidatorDecorators;

namespace SD2.Patterns.Decorator.Validation.Vlaidators
{
    public class Validator<T> : AbstractValidator<T>
    {
        public List<AbstractValidator<T>> Validators { get; set; } = new List<AbstractValidator<T>>();

        public override bool Validate(T itemToValidate)
        {
            var inValidState = true;

            foreach (var validator in Validators)
            {
                var wasValid = validator.Validate(itemToValidate);

                if (wasValid == false)
                {
                    inValidState = wasValid;
                    ErrorMessages.AddRange(validator.ErrorMessages);
                }
            }

            return inValidState;
        }
    }
}
