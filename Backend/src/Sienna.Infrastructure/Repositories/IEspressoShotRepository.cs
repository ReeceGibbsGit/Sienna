using Microsoft.EntityFrameworkCore;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Infrastructure.Repositories
{
    public interface IEspressoShotRepository : IDisposable
    {
        DbSet<EspressoShot> EspressoShots { get; set; }
        Task<List<EspressoShot>> GetEspressoShotsAsync();
        ValueTask<EspressoShot?> GetEspressoShotById(Guid id);
        Task<int> SaveChangesAsync();
        void Add(EspressoShot espressoShot);
        void Delete(EspressoShot espressoShot);
    }
}
