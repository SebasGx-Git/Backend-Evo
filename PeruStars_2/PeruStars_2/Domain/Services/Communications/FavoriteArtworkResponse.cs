using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class FavoriteArtworkResponse : BaseResponse<FavoriteArtwork>
    {
        public FavoriteArtworkResponse(FavoriteArtwork resource) : base(resource)
        {
        }

        public FavoriteArtworkResponse(string message) : base(message)
        {
        }
    }
}
