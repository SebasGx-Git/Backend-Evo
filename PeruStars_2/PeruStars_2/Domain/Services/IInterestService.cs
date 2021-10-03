using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IInterestService
    {
        Task<IEnumerable<Interest>> ListAsync();
        Task<IEnumerable<Interest>> ListByHobbyistsIdAsync(long HobbyistId);
        Task<InterestResponse> AssingInterestAsync(long HobbyistId, long SpecialtyId);
        Task<InterestResponse> UnassignInterestAsync(long HobbyistId, long SpecialtyId);
    }
}
