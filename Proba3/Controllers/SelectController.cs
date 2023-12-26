using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proba3.Data;
using Proba3.Models;
using Proba3.ViewModels;




namespace Proba3.Controllers
{
    public class SelectController : Controller
    {
        private readonly Proba3Context _context;
        public SelectController(Proba3Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ManufacturerModel manufacturer = new ManufacturerModel();
            manufacturer.Name = "Name";
            IndexViewModel ivm = new IndexViewModel();


           //var manufacturers = await _context.Manufacturer.ToListAsync();
            //IEnumerable<string> names = from p in manufacturers select p.Title;
        
            return View(await _context.Manufacturer.ToListAsync());
        }
  

        public async Task<IActionResult> GetAll()
        {
            var items = await _context.Manufacturer.ToListAsync();
            //var ManufacturerList = from p in item select p.Title;
         
            return View(items);
        }
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var item =await _context.Manufacturer.FirstOrDefaultAsync(p => p.Id == Id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        
        }
    }
}
