using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class ContentTypeDto : BaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
