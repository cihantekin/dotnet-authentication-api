using System.ComponentModel.DataAnnotations;

namespace dotnet_authentication_api.Model.Dto
{
    public class LoginRequestDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string  Password { get; set; } = string.Empty;
    }
}
