using Microsoft.AspNetCore.Mvc;
using ProjetoBase.Models;
using System.Diagnostics;

namespace ProjetoBase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Demonstrativo()
        {
            return View("Demonstrativo");
        }

        public IActionResult Despesas()
        {
            return View();
        }
        public IActionResult Receitas()
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