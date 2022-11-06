using System.ComponentModel.DataAnnotations;

namespace dotnet_authentication_api.Model.Dto
{
    public class RegisterRequestDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
