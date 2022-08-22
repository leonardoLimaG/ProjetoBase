using Microsoft.AspNetCore.Mvc;
using ProjetoBase.Models;
using System.Diagnostics;

namespace ProjetoBase.Controllers
{
    public class DespesaController : Controller
    {
        public IActionResult CriarDespesa()
        {
            return View();
        }
    }
}
