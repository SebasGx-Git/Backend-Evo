using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Persistence.Repositories
{
    public interface IArtistRepository
    {
        Task<IEnumerable<Artist>> ListAsync();
        Task AddAsync(Artist artist);
        Task<Artist> FindById(long id);
        void Update(Artist artist);
        void Remove(Artist artist);

        Task<bool> isSameBrandingName(string brandingname);
    }
}
