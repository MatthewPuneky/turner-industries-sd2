namespace SD2.Patterns.Decorator.Validation.ValidatorDecorators.StringValidators
{
    public class StringIsLessThanMaxLength : AbstractValidator<string>
    {
        private readonly int _maxLength;

        public StringIsLessThanMaxLength(int maxLength)
        {
            _maxLength = maxLength;
        }

        public override bool Validate(string itemToValidate)
        {
            var validationState = itemToValidate.Length > _maxLength;

            if (!validationState)
            {
                ErrorMessages.Add($"{itemToValidate} was longer than the max length of {_maxLength}");
            }

            return validationState;
        }
    }
}
