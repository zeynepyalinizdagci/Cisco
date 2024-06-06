namespace HttpTagServer.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public List<Tag> SubTags { get; set; } = new List<Tag>();

        public Tag(string name)
        {
            Name = name;
            SubTags = new List<Tag>();
        }
    }
}
