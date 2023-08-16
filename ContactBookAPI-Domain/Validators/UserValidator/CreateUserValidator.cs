using ContactBookAPI_Domain.Dtos.Requests;
using FluentValidation;

namespace ContactBookAPI_Domain.Validators.UserValidator
{
    public class CreateUserValidator : AbstractValidator<UserRequestDto>
    {
        public CreateUserValidator()
        {
            RuleFor(u => u.FullName).NotEmpty().WithMessage("FullName field is required");
            RuleFor(u => u.Email).EmailAddress().WithMessage("Email entered is not a valid EmailAddress");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Password field is required");
        }
    }
}