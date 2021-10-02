using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<Artist>> ListAsync();
        Task<ArtistResponse> GetByIdAsync(long id);
        Task<ArtistResponse> SaveAsync(Artist artist);
        Task<ArtistResponse> UpdateAsync(long id, Artist artist);
        Task<ArtistResponse> DeleteAsync(long id);
    }
}
