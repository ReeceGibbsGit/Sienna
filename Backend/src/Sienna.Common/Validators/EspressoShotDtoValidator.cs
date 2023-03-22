using FluentValidation;
using Sienna.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Domain.Validators
{
    public class EspressoShotDtoValidator : AbstractValidator<EspressoShotDto>
    {
        public EspressoShotDtoValidator()
        {
            RuleFor(espressoShot => espressoShot.Grind).InclusiveBetween(0.0, 6.0);
            RuleFor(espressoShot => espressoShot.Flavour).InclusiveBetween(1, 5);
            RuleFor(espressoShot => espressoShot.Rating).InclusiveBetween(1, 5);
        }
    }
}
