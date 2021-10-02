using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Persistence.Repositories;
using PeruStars_2.Domain.Services;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Services
{
    public class SpecialtyService : ISpecialtyService
    {
        private readonly ISpecialtyRepository _specialtyRepository;
        private readonly IUnitofWork _unitOfWork;

        public SpecialtyService(ISpecialtyRepository specialtyRepository, IUnitofWork unitOfWork)
        {
            _specialtyRepository = specialtyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<SpecialtyResponse> GetByIdAsync(long id)
        {
            var existingSpecialty = await _specialtyRepository.FindById(id);
            if (existingSpecialty == null)
                return new SpecialtyResponse("Specialty not found");
            return new SpecialtyResponse(existingSpecialty);
        }

        public async Task<IEnumerable<Specialty>> ListAsync()
        {
            return await _specialtyRepository.ListAsync();
        }
    }
}
