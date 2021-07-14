using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(p => p.ContactNick).NotEmpty();
            RuleFor(p => p.ContactNick).MinimumLength(2);
            RuleFor(p => p.ContactNumber).NotEmpty();
            RuleFor(p => p.ContactNumber).MinimumLength(2);
        }
    }


}
