using Microsoft.EntityFrameworkCore;
using Sienna.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Data.Contexts
{
    public class EspressoShotContext : DbContext, IEspressoShotContext
    {
        public EspressoShotContext(DbContextOptions options) : base(options) { }

        public DbSet<EspressoShot> EspressoShots { get; set; }

        public void Add(EspressoShot espressoShot) => EspressoShots.Add(espressoShot);

        public void Delete(EspressoShot espressoShot) => base.Entry(espressoShot).State = EntityState.Deleted;

        public Task<int> SaveChangesAsync() => base.SaveChangesAsync();
    }
}
