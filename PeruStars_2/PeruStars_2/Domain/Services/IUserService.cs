using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Services
{
    public interface IUserService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<IEnumerable<User>> GetAllAsync();
        Task RegisterAsync(RegisterRequest request);
    }
}
