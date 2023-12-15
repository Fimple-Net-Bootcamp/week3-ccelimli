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
    public class ActivityValidator : AbstractValidator<Activity>
    {
        public ActivityValidator()
        {
            RuleFor(activity => activity.Type).NotEmpty().WithMessage(Messages.NotEmptyActiviteInfo);

        }
    }
}
