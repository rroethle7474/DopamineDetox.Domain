using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class TopicDto : BaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; } = true;
        [JsonPropertyName("term")]
        public string? Term { get; set; }
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
    }
}
