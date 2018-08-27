using System.Collections.Generic;

namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators
{
    public abstract class AbstractValidator<T>
    {
        public List<string> ErrorMessages { get; set; } = new List<string>();
        public abstract bool Validate(T itemToValidate);
    }
}
