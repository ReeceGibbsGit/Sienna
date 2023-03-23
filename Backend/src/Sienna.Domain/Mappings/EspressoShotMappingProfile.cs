using AutoMapper;
using Sienna.Common.Models;
using Sienna.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Common.Mappings
{
    public class EspressoShotMappingProfile : Profile
    {
        public EspressoShotMappingProfile()
        {
            CreateMap<EspressoShotDto, EspressoShot>();
            CreateMap<EspressoShot, EspressoShotDto>();
        }
    }
}
