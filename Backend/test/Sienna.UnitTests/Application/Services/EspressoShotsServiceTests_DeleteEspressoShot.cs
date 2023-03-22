using FluentAssertions;
using Moq;
using Sienna.Domain.Exceptions;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sienna.UnitTests.Application.Services
{
    public class EspressoShotsServiceTests_DeleteEspressoShot : EspressoShotsServiceTests_Base
    {
        [Fact]
        public async Task DeleteEspressoShot_Should_Return_Id_Upon_Deletion()
        {
            // Arrange
            var mockGuid = Guid.NewGuid();

            // not sure about the green squiggles here. Is there a better way to do this?
            _mockRepository.Setup(x => x.GetEspressoShotById(It.IsAny<Guid>())).Returns(ValueTask.FromResult(new EspressoShot()));
            _mockRepository.Setup(x => x.Delete(It.IsAny<EspressoShot>())).Callback(() => { return; });
            _mockRepository.Setup(x => x.SaveChangesAsync()).Returns(Task.FromResult(0));

            // Act
            var result = await _service.DeleteEspressoShot(mockGuid);

            // Assert
            result.Should().Be(mockGuid);
        }

        [Fact]
        public void DeleteEspressoShot_Should_Throw_NotFoundException_If_Object_Not_Found()
        {
            // Arrange
            _mockRepository.Setup(x => x.GetEspressoShotById(It.IsAny<Guid>())).Returns(null);

            // Act
            var action = async () => await _service.DeleteEspressoShot(Guid.NewGuid());

            // Assert
            action.Should().ThrowAsync<NotFoundException>();
        }
    }
}
