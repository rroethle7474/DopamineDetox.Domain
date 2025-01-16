using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class BaseDto
    {
        [JsonPropertyName("createdOn")]
        public DateTime CreatedOn { get; set; }
        [JsonPropertyName("updatedOn")]
        public DateTime UpdatedOn { get; set; }
    }
}
