using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class ChannelDto : BaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
        [JsonPropertyName("channelName")]
        public string? ChannelName { get; set; }
        [JsonPropertyName("identifier")]
        public string? Identifier { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("contentTypeId")]
        public int ContentTypeId { get; set; }
        [JsonPropertyName("contentTypeName")]
        public string? ContentTypeName { get; set; }
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
    }
}
