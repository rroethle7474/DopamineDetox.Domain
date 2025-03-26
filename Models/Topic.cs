namespace DopamineDetox.Domain.Models
{
    // used for organizing in a folder type structure
    public class Topic : BaseModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public string Term { get; set; } = "";
        public string? UserId { get; set; }
        public bool ExcludeFromTwitter { get; set; }
        public User? User { get; set; }
    }
}
