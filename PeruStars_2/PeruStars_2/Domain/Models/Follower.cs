using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Models
{
    public class Follower
    {
        public Hobbyist Hobbyist { get; set; }
        public long HobbyistId { get; set; }

        public Artist Artist { get; set; }
        public long ArtistId { get; set; }
    }
}
