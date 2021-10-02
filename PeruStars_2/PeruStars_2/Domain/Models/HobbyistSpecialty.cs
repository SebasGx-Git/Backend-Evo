using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Models
{
    public class HobbyistSpecialty
    {
        public long HobbyistId { get; set; }
        public Hobbyist Hobbyist { get; set; }
        public long SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
