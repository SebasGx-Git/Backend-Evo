using Microsoft.EntityFrameworkCore;
using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Persistence.Contexts;
using PeruStars_2.Domain.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Persistence.Repositories
{
    public class SpecialtyRepository : BaseRepository, ISpecialtyRepository
    {
        public SpecialtyRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Specialty> FindById(long specialtyId)
        {
            return await _context.Specialties.FindAsync(specialtyId);
        }

        public async Task<IEnumerable<Specialty>> ListAsync()
        {
            return await _context.Specialties.ToListAsync();
        }
    }
}
