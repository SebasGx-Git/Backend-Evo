using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IHobbyistSpecialtyService
    {
        Task<IEnumerable<HobbyistSpecialty>> ListAsync();
        Task<IEnumerable<HobbyistSpecialty>> ListByHobbyistsIdAsync(long HobbyistId);
        Task<HobbyistSpecialtyResponse> AssignHobbyistSpecialtyAsync(long HobbyistId, long SpecialtyId);
        Task<HobbyistSpecialtyResponse> UnassignHobbyistSpecialtyAsync(long HobbyistId, long SpecialtyId);
    }
}
