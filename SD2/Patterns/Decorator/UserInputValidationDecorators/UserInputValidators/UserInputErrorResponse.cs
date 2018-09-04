using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Decorator.UserInputValidationDecorators.UserInputValidators
{
    public class UserInputErrorResponse
    {
        public string UserInput { get; set; }
        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
