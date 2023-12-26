using Proba.Models;

namespace Proba.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Equipment> Equipments { get; set; }
        public IEnumerable<Producer> Producers { get; set; }
    }
}
