using foodiestopia.Models;

namespace foodiestopia.Interfaces
{
    public interface IJwtTokenService
    {
        Task<string> CreateTokenAsync(AppUser user);
    }
}