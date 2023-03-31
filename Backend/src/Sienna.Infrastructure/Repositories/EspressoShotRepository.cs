using Microsoft.EntityFrameworkCore;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Infrastructure.Repositories
{
    public class EspressoShotRepository : DbContext, IEspressoShotRepository
    {
        public EspressoShotRepository(DbContextOptions options) : base(options) { }

        public DbSet<EspressoShot> EspressoShots { get; set; }

        public Task<List<EspressoShot>> GetEspressoShotsAsync() => EspressoShots.OrderBy(e => e.TimeStamp).ToListAsync();

        public ValueTask<EspressoShot?> GetEspressoShotById(Guid id) => EspressoShots.FindAsync(id);

        public void Add(EspressoShot espressoShot) => EspressoShots.Add(espressoShot);

        public void Delete(EspressoShot espressoShot) => base.Entry(espressoShot).State = EntityState.Deleted;

        public Task<int> SaveChangesAsync() => base.SaveChangesAsync();


    }
}
