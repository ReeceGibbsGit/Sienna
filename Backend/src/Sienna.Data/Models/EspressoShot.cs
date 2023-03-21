using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Infrastructure.Models
{
    public class EspressoShot
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(128)]
        public string? BeanType { get; set; }

        public double Grind { get; set; }

        public double Beans { get; set; }

        public double Pressure { get; set; }

        public double Water { get; set; }

        public double BrewTime { get; set; }

        public int Flavour { get; set; }

        public int Rating { get; set; }

        [StringLength(256)]
        public string? Comments { get; set; }
    }
}
