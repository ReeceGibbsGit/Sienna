using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Common.Models
{
    public class EspressoShotDto
    {
        public string? BeanType { get; set; }

        public double Grind { get; set; }

        public double Beans { get; set; }

        public double Pressure { get; set; }

        public double Water { get; set; }

        public double BrewTime { get; set; }

        public int Flavour { get; set; }

        public double Rating { get; set; }

        public string? Comments { get; set; }
    }
}
