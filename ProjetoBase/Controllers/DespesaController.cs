using Microsoft.AspNetCore.Mvc;
using ProjetoBase.Models;
using ProjetoBase.Repositorio;
using System.Diagnostics;

namespace ProjetoBase.Controllers
{
    public class DespesaController : Controller
    {
        private readonly IDespesaRepositorio _despesaRepositorio;
        public DespesaController(IDespesaRepositorio despesaRepositorio) {

        }
       
        public IActionResult CriarDespesa()
        {
            return View();
        }

        
        public IActionResult AlterarDespesa()
        {
            return View("AlterarDespesa");
        }
        public IActionResult CriarCategoria()
        {
            return View("CriarCategoria");
        }

    }
}
