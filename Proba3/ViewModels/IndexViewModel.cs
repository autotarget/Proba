using Proba3.Migrations;
using Proba3.Models;

namespace Proba3.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<ManufacturerModel> Manufacturers { get; set; }   
        public IEnumerable<Migrations.Equipment> Equipments { get; set; }
    }
}
