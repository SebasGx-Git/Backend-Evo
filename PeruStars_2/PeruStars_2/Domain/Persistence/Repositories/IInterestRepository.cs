using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Persistence.Repositories
{
    public interface IInterestRepository
    {
        Task<IEnumerable<Interest>> ListAsync();
        Task<IEnumerable<Interest>> ListByHobbyistIdAsync(long hobbyistId);
        Task<Interest> FindByHobbyistIdAndSpecialtyId(long hobbyistId, long specialtyId);
        Task AddAsync(Interest interest);
        void Remove(Interest interest);
        Task AssignInterest(long hobbyistId, long specialtyId);
        Task UnassignInterest(long hobbyistId, long specialtyId);
    }
}
