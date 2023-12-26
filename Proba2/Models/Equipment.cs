using System.ComponentModel.DataAnnotations;

namespace Proba2.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Model { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturedDate { get; set; }
        public string? Ser_num { get; set; }
        public decimal Inv_num { get; set; }
    }
}
