using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class DefaultTopicDto : BaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("term")]
        public string? Term { get; set; }
    }
}
