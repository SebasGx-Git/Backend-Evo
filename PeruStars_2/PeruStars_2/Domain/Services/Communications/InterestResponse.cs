using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class InterestResponse : BaseResponse<Interest>
    {
        public InterestResponse(Interest resource) : base(resource)
        {
        }

        public InterestResponse(string message) : base(message)
        {
        }
    }
}
