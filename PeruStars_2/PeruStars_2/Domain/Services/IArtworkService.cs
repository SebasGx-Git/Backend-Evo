using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IArtworkService
    {
        Task<IEnumerable<Artwork>> ListAsync();

        Task<IEnumerable<Artwork>> ListByArtistIdAsync(long Id);
        Task<ArtworkResponse> GetByIdAsync(long id);
        Task<ArtworkResponse> SaveAsync(Artwork artwork);
        Task<ArtworkResponse> UpdateAsync(long id, Artwork artwork);
        Task<ArtworkResponse> DeleteAsync(long id);
    }
}
