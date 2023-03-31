using Microsoft.EntityFrameworkCore;
using Sienna.Infrastructure.Repositories;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sienna.Domain.Exceptions;

namespace Sienna.Application.Services
{
    public class EspressoShotsService : IEspressoShotsService
    {
        private readonly IEspressoShotRepository _repository;

        public EspressoShotsService(IEspressoShotRepository repository) => _repository = repository;

        public Task<List<EspressoShot>> GetEspressoShots() => _repository.GetEspressoShotsAsync();

        public async Task<EspressoShot> CreateEspressoShot(EspressoShot espressoShot)
        {
            espressoShot.TimeStamp = DateTime.Now;

            _repository.Add(espressoShot);
            await _repository.SaveChangesAsync();

            return espressoShot;
        }

        public async Task<Guid> DeleteEspressoShot(Guid id)
        {
            var espressoShot = await _repository.GetEspressoShotById(id);

            if (espressoShot == null)
            {
                throw new NotFoundException("EspressoShot", id);
            }

            _repository.Delete(espressoShot);
            await _repository.SaveChangesAsync();

            return id;
        }
    }
}
