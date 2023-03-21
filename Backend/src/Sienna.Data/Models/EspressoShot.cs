using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sienna.Data.Models
{
    public class EspressoShot
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(128)]
        public string? BeanType { get; set; }

        public double Grind { get; set; }

        public int Beans { get; set; }

        public int Pressure { get; set; }

        public int Water { get; set; }

        public int BrewTime { get; set; }

        public int Flavour { get; set; }

        public int Rating { get; set; }

        [StringLength(256)]
        public string? Comments { get; set; }
    }
}
