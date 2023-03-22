using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
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
    public class EspressoShotsControllerTests_GetEspressoShots : EspressoShotsControllerTests_Base
    {
        public EspressoShotsControllerTests_GetEspressoShots()  
            : base()
        {
        }

        [Fact]
        public async Task GetEspressoShots_Should_Return_Ok_And_Valid_List_On_Success()
        {
            // Arrange
            var mockEspressoShots = new List<EspressoShot> {
                new EspressoShot
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
                },
                new EspressoShot
                {
                    Id = Guid.NewGuid(),
                    BeanType = "Avalanche Franz Josef",
                    Grind = 1.4,
                    Beans = 14.0,
                    Pressure = 8.0,
                    Water = 88.0,
                    BrewTime = 47.0,
                    Flavour = 4,
                    Rating = 3.0,
                    Comments = "Slightly bitter, but nice."
                }
            };

            _mockService.Setup(x => x.GetEspressoShots()).Returns(Task.FromResult(mockEspressoShots));

            // Act
            var results = (ObjectResult)await _espressoShotsController.GetEspressoShots();

            // Assert
            results.StatusCode.Should().Be((int)HttpStatusCode.OK);
            results.Value.Should().BeEquivalentTo(mockEspressoShots);
        }
    }
}
