using AutoMapper;
using PeruStars_2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PeruStars_2.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Artist, ArtistResource>();
            CreateMap<Hobbyist, HobbyistResource>();
            CreateMap<Person, PersonResource>();
            CreateMap<Event, EventResource>();
            CreateMap<ClaimTicket, ClaimTicketResource>();
            CreateMap<EventAssistance, EventAssistanceResource>();
            CreateMap<Artwork, ArtworkResource>();
            CreateMap<Specialty, SpecialtyResource>();

        }
    }
}
