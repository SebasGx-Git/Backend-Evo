using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IFavoriteArtworkService
    {
        Task<IEnumerable<FavoriteArtwork>> ListAsync();
        Task<IEnumerable<FavoriteArtwork>> ListByHobbyistIdAsync(long Id); //HALLA LAS OBRAS FAVORITAS SEGUN EL ID DEL AFICIONADO 
        Task<FavoriteArtworkResponse> AssignFavoriteArtworkAsync(long HobbyistId, long ArtworkId);
        Task<FavoriteArtworkResponse> UnassignFavoriteArtworkAsync(long HobbyistId, long ArtworkId);
    }
}
