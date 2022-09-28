using ASPColoradoBestCars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPColoradoBestCars.Controllers
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
            CarProperty car = new CarProperty();
            return View(car);
        }
        public IActionResult ViewCar(CarProperty car)
        {
            var vehicle = ApiCall.CallAPI(car.Make);
            return View(vehicle);    
                
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}