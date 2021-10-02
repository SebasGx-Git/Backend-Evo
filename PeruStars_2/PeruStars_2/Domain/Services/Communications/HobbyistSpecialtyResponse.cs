using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class HobbyistSpecialtyResponse : BaseResponse<HobbyistSpecialty>
    {
        public HobbyistSpecialtyResponse(HobbyistSpecialty resource) : base(resource)
        {
        }

        public HobbyistSpecialtyResponse(string message) : base(message)
        {
        }
    }
}
