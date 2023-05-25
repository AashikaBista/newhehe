using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Workshop.Models;

namespace Workshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = new List<HomeVm>(){
            new HomeVm() { Id = 1, Name = "one", Address = "Addr one" },
            new HomeVm() { Id = 2, Name = "two", Address = "Addr two" }
            };
            return View(list);
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
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