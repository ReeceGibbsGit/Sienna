using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Application.Services
{
    public interface IEspressoShotsService
    {
        Task<List<EspressoShot>> GetEspressoShotList();
        Task<EspressoShot> CreateEspressoShot(EspressoShot espressoShot);
        Task<Guid> DeleteEspressoShot(Guid id);
    }
}
