using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Sienna.Infrastructure.Repositories;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sienna.Application.Services;

namespace Sienna.UnitTests.Application.Services
{
    public class EspressoShotsServiceTests_Base
    {
        protected readonly Mock<IEspressoShotRepository> _mockRepository;
        protected readonly EspressoShotsService _service;

        public EspressoShotsServiceTests_Base()
        {
            _mockRepository = new Mock<IEspressoShotRepository>();
            _service = new EspressoShotsService(_mockRepository.Object);
        }
    }
}
