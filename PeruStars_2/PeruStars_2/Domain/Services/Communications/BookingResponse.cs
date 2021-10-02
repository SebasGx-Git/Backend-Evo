using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services.Communications
{
    public class BookingResponse : BaseResponse<Booking>
    {
        public BookingResponse(Booking resource) : base(resource)
        {
        }

        public BookingResponse(string message) : base(message)
        {
        }
    }
}
