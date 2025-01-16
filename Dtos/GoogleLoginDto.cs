using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class GoogleLoginDto
    {
        [JsonPropertyName("idToken")]
        public string? IdToken { get; set; }
    }
}
