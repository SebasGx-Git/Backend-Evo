using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IHobbyistService
    {
        Task<IEnumerable<Hobbyist>> ListAsync();
        Task<HobbyistResponse> GetByIdAsync(long id);
        Task<HobbyistResponse> SaveAsync(Hobbyist hobbyist);
        Task<HobbyistResponse> UpdateAsync(long id, Hobbyist hobbyist);
        Task<HobbyistResponse> DeleteAsync(long id);
    }
}
