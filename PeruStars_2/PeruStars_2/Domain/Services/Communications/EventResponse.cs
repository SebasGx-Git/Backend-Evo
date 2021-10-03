using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class EventResponse : BaseResponse<Event>
    {
        public EventResponse(Event resource) : base(resource)
        {
        }

        public EventResponse(string message) : base(message)
        {
        }
    }
}
