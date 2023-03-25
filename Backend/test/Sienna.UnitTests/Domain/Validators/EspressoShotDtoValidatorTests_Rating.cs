using FluentValidation.TestHelper;
using Sienna.Domain;
using Sienna.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sienna.UnitTests.Domain.Validators
{
    public class EspressoShotDtoValidatorTests_Rating : EspressoShotDtoValidatorTests_Base
    {
        [Fact]
        public void Rating_Rule_Should_Fail_Less_Than_One()
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
                Rating = 0.5,
                Comments = "Perfectly balanced. Really good."
            };

            // Act
            var result = _validator.TestValidate(mockEspressoShotDto);

            // Assert
            result.ShouldHaveValidationErrorFor(e => e.Rating).Only();
        }

        [Fact]
        public void Rating_Rule_Should_Fail_Greater_Than_Five()
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
                Rating = 5.5,
                Comments = "Perfectly balanced. Really good."
            };

            // Act
            var result = _validator.TestValidate(mockEspressoShotDto);

            // Assert
            result.ShouldHaveValidationErrorFor(e => e.Rating).Only();
        }

        [Fact]
        public void Rating_Rule_Should_Pass_Between_One_And_Five()
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
            result.ShouldNotHaveValidationErrorFor(e => e.Rating);
        }
    }
}
