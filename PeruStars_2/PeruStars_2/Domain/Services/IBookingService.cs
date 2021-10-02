using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> ListAsync();

        Task<IEnumerable<Booking>> ListAsyncByHobbyistId(long Id);

        Task<BookingResponse> AssignBookingAsync(long HobbyistId, long EventId);
        Task<BookingResponse> UnassignBookingAsync(long HobbyistId, long EventId);
    }
}
