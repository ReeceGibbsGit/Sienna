using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Sienna.Common.Models;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sienna.UnitTests.Api.Controllers
{
    public class EspressoShotsControllerTests_CreateEspressoShot : EspressoShotsControllerTests_Base
    {
        public EspressoShotsControllerTests_CreateEspressoShot()
            : base()
        {
        }

        [Fact]
        public async Task CreateEspressoShot_Should_Return_Ok_And_Valid_EspressoShot_Object_On_Success()
        {
            // Arrange
            var mockEspressoShot = new EspressoShot
            {
                Id = Guid.NewGuid(),
                BeanType = "Avalanche Melt",
                Grind = 1.4,
                Beans = 15.0,
                Pressure = 7.0,
                Water = 90.0,
                BrewTime = 52.0,
                Flavour = 3,
                Rating = 4.0,
                Comments = "Perfectly balanced. Really good."
            };

            _mockService.Setup(x => x.CreateEspressoShot(It.IsAny<EspressoShot>())).Returns(Task.FromResult(mockEspressoShot));

            // Act
            var results = (ObjectResult)await _espressoShotsController.CreateEspressoShot(new EspressoShotDto());

            // Assert
            results.StatusCode.Should().Be((int)HttpStatusCode.OK);
            results.Value.Should().BeEquivalentTo(mockEspressoShot);
        }
    }
}
