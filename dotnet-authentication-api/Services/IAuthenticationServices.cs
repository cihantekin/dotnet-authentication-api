using dotnet_authentication_api.Model.Dto;

namespace dotnet_authentication_api.Services
{
    public interface IAuthenticationServices
    {
        Task<string> Register(RegisterRequestDto request);
        Task<string> Login(LoginRequestDto request);
    }
}
