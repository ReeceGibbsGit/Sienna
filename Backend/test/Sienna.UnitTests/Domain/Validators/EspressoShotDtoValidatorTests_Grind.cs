using FluentValidation.TestHelper;
using Sienna.Domain;
using Sienna.Domain.Entities;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sienna.UnitTests.Domain.Validators
{
    public class EspressoShotDtoValidatorTests_Grind : EspressoShotDtoValidatorTests_Base
    {
        [Fact]
        public void Grind_Rule_Should_Fail_Less_Than_Zero()
        {
            // Arrange
            var mockEspressoShotDto = new EspressoShotDto
            {
                BeanType = "Avalanche Melt",
                Grind = -1.0,
                Beans = 15.0,
                Pressure = 7.0,
                Water = 90.0,
                BrewTime = 52.0,
                Flavour = 3,
                Rating = 4.0,
                Comments = "Perfectly balanced. Really good."
            };

            // Act
            var result = _validator.TestValidate(mockEspressoShotDto);

            // Assert
            result.ShouldHaveValidationErrorFor(e => e.Grind).Only();
        }

        [Fact]
        public void Grind_Rule_Should_Fail_Greater_Than_Six()
        {
            // Arrange
            var mockEspressoShotDto = new EspressoShotDto
            {
                BeanType = "Avalanche Melt",
                Grind = 6.1,
                Beans = 15.0,
                Pressure = 7.0,
                Water = 90.0,
                BrewTime = 52.0,
                Flavour = 3,
                Rating = 4.0,
                Comments = "Perfectly balanced. Really good."
            };

            // Act
            var result = _validator.TestValidate(mockEspressoShotDto);

            // Assert
            result.ShouldHaveValidationErrorFor(e => e.Grind).Only();
        }

        [Fact]
        public void Grind_Rule_Should_Pass_Between_Zero_And_Six()
        {
            // Arrange
            var mockEspressoShotDto = new EspressoShotDto
            {
                BeanType = "Avalanche Melt",
                Grind = 5.0,
                Beans = 15.0,
                Pressure = 7.0,
                Water = 90.0,
                BrewTime = 52.0,
                Flavour = 3,
                Rating = 4.0,
                Comments = "Perfectly balanced. Really good."
            };

            // Act
            var result = _validator.TestValidate(mockEspressoShotDto);

            // Assert
            result.ShouldNotHaveValidationErrorFor(e => e.Grind);
        }
    }
}
