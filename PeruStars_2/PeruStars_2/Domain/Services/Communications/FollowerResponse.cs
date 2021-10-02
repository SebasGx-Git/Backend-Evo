using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class FollowerResponse : BaseResponse<Follower>
    {
        public FollowerResponse(Follower resource) : base(resource)
        {
        }

        public FollowerResponse(string message) : base(message)
        {
        }
    }
}
