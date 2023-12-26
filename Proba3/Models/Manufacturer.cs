using System.ComponentModel.DataAnnotations;


namespace Proba3.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        public string? Title { get; set; }

        [Display(Name = "Описание")]
        public string? Description { get; set; }
    }
}
