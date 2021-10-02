using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class ArtworkResponse : BaseResponse<Artwork>
    {
        public ArtworkResponse(Artwork resource) : base(resource)
        {
        }

        public ArtworkResponse(string message) : base(message)
        {
        }
    }
}
