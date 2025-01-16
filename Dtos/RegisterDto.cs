using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class RegisterDto
    {
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }
        public bool IsAdmin { get; set; } = false;
    }   
}
