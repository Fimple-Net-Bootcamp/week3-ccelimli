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
    public class HealthStatusValidator : AbstractValidator<HealthStatus>
    {
        public HealthStatusValidator()
        {
            RuleFor(healthStatus => healthStatus.PetId).NotEmpty().WithMessage(Messages.NotEmptyPetInfo);

        }
    }
}
