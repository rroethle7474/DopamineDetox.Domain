using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class ApplicationUserDto
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("userName")]
        public string? UserName { get; set; }
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [JsonPropertyName("googleEmail")]
        public string? GoogleEmail { get; set; }
        [JsonPropertyName("isAdmin")]
        public bool IsAdmin { get; set; }
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }
    }
}
