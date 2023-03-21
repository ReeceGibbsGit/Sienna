using AutoMapper;
using Moq;
using Sienna.Application.Controllers;
using Sienna.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.UnitTests.Api.Controllers
{
    public class EspressoShotsControllerTests_Base
    {
        protected readonly Mock<IEspressoShotsService> _mockService;
        protected readonly Mock<IMapper> _mockMapper;
        protected readonly EspressoShotsController _espressoShotsController;

        public EspressoShotsControllerTests_Base()
        {
            _mockService = new Mock<IEspressoShotsService>();
            _mockMapper = new Mock<IMapper>();
            _espressoShotsController = new EspressoShotsController(_mockMapper.Object, _mockService.Object);
        }
    }
}
