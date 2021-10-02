using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class SpecialtyResponse : BaseResponse<Specialty>
    {
        public SpecialtyResponse(Specialty resource) : base(resource)
        {
        }

        public SpecialtyResponse(string message) : base(message)
        {
        }
    }
}
