using Business.Constant;
using Entity.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PetValidator : AbstractValidator<Pet>
    {
        public PetValidator()
        {
            RuleFor(pet => pet.PetName).NotEmpty().WithMessage(Messages.NotEmptyPetName);
            RuleFor(pet => pet.UserId).NotEmpty().WithMessage(Messages.NotEmptyUserInfo);

        }
    }
}
