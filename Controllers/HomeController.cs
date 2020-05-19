using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreExample.Models;

namespace CoreExample.Controllers
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
            _logger.LogInformation("Test");
            return View();
        }

        [HttpGet]
        public IActionResult Regist()
        {
            return RedirectToAction(nameof(Index), TempData["StatusMessage"] = "Regist Status Message");
        }

        [HttpPost]
        public IActionResult Regist(string UserEmail)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string qwer)
        {
            return RedirectToAction(nameof(Index));
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
