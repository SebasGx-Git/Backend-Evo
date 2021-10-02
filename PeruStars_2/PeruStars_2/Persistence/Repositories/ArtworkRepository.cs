using Microsoft.EntityFrameworkCore;
using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Persistence.Contexts;
using PeruStars_2.Domain.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Persistence.Repositories
{
    public class ArtworkRepository : BaseRepository, IArtworkRepository
    {
        public ArtworkRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Artwork artwork)
        {
            await _context.Artworks.AddAsync(artwork);
        }

        public async Task<Artwork> FindById(long artworkId)
        {
            return await _context.Artworks.FindAsync(artworkId);
        }

        public async Task<bool> isSameTitle(string title, long artistId)
        {
            var artworksWithSameTilte = await _context.Artworks
                                                .Where(pt => pt.ArtistId == artistId
                                                 && pt.ArtTitle == title)
                                                .ToListAsync();

            return artworksWithSameTilte.Count > 0;

           
        }

        public async Task<IEnumerable<Artwork>> ListAsync()
        {
            return await _context.Artworks.ToListAsync();
        }

        public async Task<IEnumerable<Artwork>> ListByArtistIdAsync(long artistId)
        {
            return await _context.Artworks
                  .Where(pt => pt.ArtistId == artistId)
                  .ToListAsync();
        }

        public void Remove(Artwork artwork)
        {
            _context.Artworks.Remove(artwork);
        }

        public void Update(Artwork artwork)
        {
            _context.Artworks.Update(artwork);
        }
    }


}
