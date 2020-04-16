using DotNetCore.Validation;
using FluentValidation;

namespace Architecture.Model
{
    public sealed class AddUserModelValidator : UserModelValidator
    {
        public AddUserModelValidator()
        {
            RuleForName();
            RuleForSurname();
            RuleForEmail();
            RuleForAuth();
        }
    }
}
