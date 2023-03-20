using Microsoft.EntityFrameworkCore;
using Sienna.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Data.Contexts
{
    public interface IEspressoShotContext : IDisposable
    {
        DbSet<EspressoShot> EspressoShots { get; set; }
        Task<int> SaveChangesAsync();
        void Add(EspressoShot espressoShot);
        void Delete(EspressoShot espressoShot);
    }
}
