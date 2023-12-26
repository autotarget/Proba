namespace Proba.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = null;
        public Producer(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

    }
}
