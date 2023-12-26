using Microsoft.AspNetCore.Mvc;
using Proba.Models;
using System.Diagnostics;
using System.Collections.Generic;
using Proba.ViewModels;

namespace Proba.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Equipment> equipments = [
            new Equipment(1, "Принтер", null, 1),
            new Equipment(2, "Монитор", null, 2),
            new Equipment(3, "Принтер", null, 1)
        ];
            var item =(from p  in equipments where p.Name == "Монитор" select p);
            return View();
        }

        public IActionResult GetList()
        {
            List<Equipment> equipments = [
            new Equipment(1, "Принтер", null, 1),
            new Equipment(4, "Монитор", null, 2),
            new Equipment(3, "Принтер", null, 1)
        ];
            IndexViewModel CommonData = new IndexViewModel()
            {
                Equipments = equipments,
                
            };
           
            return View(CommonData);
        }
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
