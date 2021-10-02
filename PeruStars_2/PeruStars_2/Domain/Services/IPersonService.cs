using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> ListAsync();
        Task<PersonResponse> GetByIdAsync(long id);
        Task<PersonResponse> SaveAsync(Person person);
        Task<PersonResponse> UpdateAsync(long id, Person person);
        Task<PersonResponse> DeleteAsync(long id);
    }
}
