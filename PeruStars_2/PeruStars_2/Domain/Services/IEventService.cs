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

        Task<IEnumerable<Event>> ListAsyncByArtistId(long Id); //Encuentra todos los eventos por Artista

        Task<IEnumerable<Event>> ListAsyncByEventType(ETypeOfEvent eTypeOf); // Encuentra todos los eventos segun Ti
        Task<EventResponse> GetByIdAsync(long id);
        Task<EventResponse> SaveAsync(Event _event);
        Task<EventResponse> UpdateAsync(long id, Event _event);
        Task<EventResponse> DeleteAsync(long id);

    }
}
