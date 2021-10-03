using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PeruStars_2.Domain.Services.Communications
{
    public class HobbyistResponse : BaseResponse<Hobbyist>
    {
        public HobbyistResponse(Hobbyist resource) : base(resource)
        {
        }

        public HobbyistResponse(string message) : base(message)
        {
        }
    }
}
