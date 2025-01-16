using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class NoteDto : BaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        [JsonPropertyName("searchResultId")]
        public int SearchResultId { get; set; }
    }
}
