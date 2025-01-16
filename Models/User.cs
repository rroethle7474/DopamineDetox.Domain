namespace DopamineDetox.Domain.Models
{
    public class User
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? GoogleEmail { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
        public List<SubTopic> SubTopics { get; set; } = new List<SubTopic>();
        public List<Channel> Channels { get; set; } = new List<Channel>();
        public List<Note> Notes { get; set; } = new List<Note>();
        public List<TopSearchResult> TopSearchResults { get; set; } = new List<TopSearchResult>();
    }
}
