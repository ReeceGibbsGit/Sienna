using FluentAssertions;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sienna.UnitTests.Application.Services
{
    public class EspressoShotsServiceTests_GetEspressoShots : EspressoShotsServiceTests_Base
    {
        public EspressoShotsServiceTests_GetEspressoShots()
            : base()
        {
        }

        [Fact]
        public async Task GetEspressoShots_Should_Return_A_List_Of_EspressoShots()
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
                    Rating = 4,
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
                    Rating = 3,
                    Comments = "Slightly bitter, but nice."
                }
            };

            _mockRepository.Setup(x => x.GetEspressoShotsAsync()).Returns(Task.FromResult(mockEspressoShots));

            // Act
            var results = await _service.GetEspressoShots();

            // Assert
            results.Should().BeEquivalentTo(mockEspressoShots);
        }
    }
}
