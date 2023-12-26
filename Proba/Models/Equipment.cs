namespace Proba.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = null;
        public int? ProducerId { get; set; }
        public Equipment(int id, string? name, string? description, int? producerId)
        {
            Id = id;
            Name = name;
            Description = description;
            ProducerId = producerId;
        }
    }   
}
