using Microsoft.AspNetCore.Identity;

namespace BeautyReserve.Services.TokenService;

public interface ITokenService
{
    string CreateToken(IdentityUser user, string role);
}
