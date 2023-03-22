using FluentAssertions;
using Moq;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.UnitTests.Application.Services
{
    public class EspressoShotsServiceTests_CreateEspressoShot : EspressoShotsServiceTests_Base
    {
        public EspressoShotsServiceTests_CreateEspressoShot()
            :base()
        {
        }

        public async Task CreateEspressoShot_Should_Return_A_Copy_Of_The_Object_Created()
        {
            // Arrange
            var mockEspressoShot = new EspressoShot
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
            };

            _mockRepository.Setup(x => x.Add(It.IsAny<EspressoShot>())).Callback(() => { return; });
            _mockRepository.Setup(x => x.SaveChangesAsync()).Returns(Task.FromResult(0));

            // Act
            var result = await _service.CreateEspressoShot(mockEspressoShot);

            // Assert
            result.Should().BeEquivalentTo(mockEspressoShot);
        } 
    }
}
