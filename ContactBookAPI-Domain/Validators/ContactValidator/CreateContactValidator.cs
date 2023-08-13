using ContactBookAPI_Domain.Dtos.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookAPI_Domain.Validators.ContactValidator
{
    public class CreateContactValidator : AbstractValidator<ContactRequestDto>
    {
        public CreateContactValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("FirstName field is required");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("LastName field is required");
            RuleFor(c => c.PhoneNumber).Matches("^(?:(\\+234)|0)([789]\\d{9})$\r\n").WithMessage("PhoneNember must be a valid Nigerian number (i.e +2348012345678, 08051234567)");
            RuleFor(c => c.Email).EmailAddress().WithMessage("Email entered is not a valid EmailAddress");
            RuleFor(c => c.Address).NotEmpty().WithMessage("Address field is required");
        }
    }
}
