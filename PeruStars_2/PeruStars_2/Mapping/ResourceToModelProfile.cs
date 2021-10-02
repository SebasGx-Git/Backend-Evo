using AutoMapper;
using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using PeruStars_2.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveArtistResource, Artist>();
            CreateMap<SavePersonResource, Person>();
            CreateMap<SaveArtworkResource, Artwork>();
            CreateMap<SaveEventResource, Event>();
            CreateMap<SaveClaimTicketResource, ClaimTicket>();
            CreateMap<SaveEventAssistanceResource, EventAssistance>();
            CreateMap<SaveHobbyistResource, Hobbyist>();
            CreateMap<RegisterRequest, User>();
        }
    }
}
