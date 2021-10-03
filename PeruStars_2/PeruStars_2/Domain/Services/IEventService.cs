using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IEventService
    {
        Task<IEnumerable<Event>> ListAsync();
        Task<IEnumerable<Event>> ListAsyncByArtistId(long artistId);
        Task<IEnumerable<Event>> ListAsyncByEventType(ETypeOfEvent eTypeOf);
        //PARA BOOKING
        Task<IEnumerable<Event>> ListByHobbyistAsync(long hobbyistId);
        Task<EventResponse> GetByIdAndArtistIdAsync(long eventId, long artistId);
        Task<EventResponse> SaveAsync(long artistId, Event _event);
        Task<EventResponse> UpdateAsync(long eventId, long artistId, Event _event);
        Task<EventResponse> DeleteAsync(long eventId, long artistId);

        Task<bool> isSameTitle(string title, long artistId);

    }
}
