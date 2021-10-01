using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Persistence.Repositories
{
    public interface ISpecialtyRepository
    {
        Task<IEnumerable<Specialty>> ListAsync();
        Task<Specialty> FindById(long specialtyId);
    }
}
