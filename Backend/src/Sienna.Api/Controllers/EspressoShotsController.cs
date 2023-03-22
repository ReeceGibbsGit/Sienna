using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sienna.Api.Filters.Auth;
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
        [ApiKey]
        [HttpGet]
        public async Task<IActionResult> GetEspressoShots()
        {
            var results = await _service.GetEspressoShots();
            return Ok(results);
        }

        // POST api/espressoshots
        [ApiKey]
        [HttpPost]
        public async Task<IActionResult> CreateEspressoShot([FromBody] EspressoShotDto espressoShotDto)
        {
            var result = await _service.CreateEspressoShot(_mapper.Map<EspressoShot>(espressoShotDto));
            return Ok(result);
        }

        // DELETE api/espressoshots
        [ApiKey]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspressoShot(Guid id)
        {
            var result = await _service.DeleteEspressoShot(id);
            return Ok(result);
        }
    }
}
