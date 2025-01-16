using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string? QuoteText { get; set; }
        public DateTime? QuoteDateFetched { get; set; }
        public byte[]? QuoteImage { get; set; }

    }
}