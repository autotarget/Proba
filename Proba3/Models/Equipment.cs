using System.ComponentModel.DataAnnotations;

namespace Proba3.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        [Display(Name ="Наименование")]
        public string? Title { get; set; }

        [Display(Name = "Модель")]
        public string? Model { get; set; }

        [Display(Name = "Серийный №")]
        [Required]
        public string? Ser_num { get; set; }

        [Display(Name = "Инвентарный №")]
        [Required]
        public string? Inv_num { get; set; }

        [Display(Name ="Производитель")]
        public int ManufacturerId { get; set; }
        public Manufacturer? Manufacturer { get; set; }
    }
}
