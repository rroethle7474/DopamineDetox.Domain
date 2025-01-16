using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class SubTopicDto : BaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
        [JsonPropertyName("term")]
        public string? Term { get; set; }
        [JsonPropertyName("topicId")]
        public int TopicId { get; set; }
        [JsonPropertyName("topicTerm")]
        public string? TopicTerm { get; set; }
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
    }
}
