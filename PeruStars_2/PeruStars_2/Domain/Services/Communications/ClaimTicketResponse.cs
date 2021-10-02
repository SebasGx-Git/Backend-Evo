﻿using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class ClaimTicketResponse : BaseResponse<ClaimTicket>
    {
        public ClaimTicketResponse(ClaimTicket resource) : base(resource)
        {
        }

        public ClaimTicketResponse(string message) : base(message)
        {
        }
    }
}
