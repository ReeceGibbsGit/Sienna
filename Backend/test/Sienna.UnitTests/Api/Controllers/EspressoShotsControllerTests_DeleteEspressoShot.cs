using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
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
    public class EspressoShotsControllerTests_DeleteEspressoShot : EspressoShotsControllerTests_Base
    {
        public EspressoShotsControllerTests_DeleteEspressoShot()
            : base()
        {
        }

        [Fact]
        public async Task DeleteEspressoShot_Should_Return_Ok_And_Valid_Guid_On_Success()
        {
            // Arrange
            var mockEspressoShotGuid = Guid.NewGuid();

            _mockService.Setup(x => x.DeleteEspressoShot(It.IsAny<Guid>())).Returns(Task.FromResult(mockEspressoShotGuid));

            // Act
            var results = (ObjectResult)await _espressoShotsController.DeleteEspressoShot(Guid.NewGuid());

            // Assert
            results.StatusCode.Should().Be((int)HttpStatusCode.OK);
            results.Value.Should().BeEquivalentTo(mockEspressoShotGuid);
        }
    }
}
