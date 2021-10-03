using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface ISpecialtyService
    {
        Task<IEnumerable<Specialty>> ListAsync();
        Task<IEnumerable<Specialty>> ListByHobbyistIdAsync(int hobbyistId);
        Task<SpecialtyResponse> GetByIdAsync(long specialtyId);       

    }
}
