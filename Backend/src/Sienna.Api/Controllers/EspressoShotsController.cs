using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sienna.Application.Services;
using Sienna.Common.Models;
using Sienna.Infrastructure.Models;

namespace Sienna.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspressoShotsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEspressoShotsService _service;

        public EspressoShotsController(IMapper mapper, IEspressoShotsService service)
        {
            _mapper = mapper;
            _service = service;
        }

        // GET api/espressoshots
        [HttpGet]
        public async Task<IActionResult> GetEspressoShots()
        {
            var results = await _service.GetEspressoShotList();
            return Ok(results);
        }

        // POST api/espressoshots
        [HttpPost]
        public async Task<IActionResult> CreateEspressoShot([FromBody] EspressoShotDto espressoShotDto)
        {
            var results = await _service.CreateEspressoShot(_mapper.Map<EspressoShot>(espressoShotDto));
            return Ok(results);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspressoShot(Guid id)
        {
            var results = await _service.DeleteEspressoShot(id);
            return Ok(results);
        }
    }
}
