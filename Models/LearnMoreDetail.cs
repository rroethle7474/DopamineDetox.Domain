using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Models
{
    public class LearnMoreDetail
    {
        public int Id { get; set; }
        public string? Introduction { get; set; }
        public string? Items { get; set; }
        public DateTime? QuoteDateFetched { get; set; }
    }
}