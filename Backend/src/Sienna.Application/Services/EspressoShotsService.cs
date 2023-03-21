using Microsoft.EntityFrameworkCore;
using Sienna.Infrastructure.Contexts;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Application.Services
{
    public class EspressoShotsService : IEspressoShotsService
    {
        private readonly IEspressoShotContext _context;

        public EspressoShotsService(IEspressoShotContext context)
        {
            _context = context;
        }

        public Task<List<EspressoShot>> GetEspressoShotList() => _context.EspressoShots.ToListAsync();

        public async Task<EspressoShot> CreateEspressoShot(EspressoShot espressoShot)
        {
            _context.Add(espressoShot);
            await _context.SaveChangesAsync();

            return espressoShot;
        }

        public async Task<Guid> DeleteEspressoShot(Guid id)
        {
            var espressoShot = await _context.EspressoShots.FindAsync(id);

            if (espressoShot == null)
            {
                // Todo: Update this to use an actual exception
                throw new Exception("Not Found");
            }

            _context.Delete(espressoShot);
            await _context.SaveChangesAsync();

            return id;
        }
    }
}
