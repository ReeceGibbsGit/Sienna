using Sienna.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.UnitTests.Domain.Validators
{
    public class EspressoShotDtoValidatorTests_Base
    {
        protected readonly EspressoShotDtoValidator _validator;
        public EspressoShotDtoValidatorTests_Base()
        {
            _validator = new EspressoShotDtoValidator();
        }
    }
}
