﻿using Microsoft.AspNetCore.Mvc;
using ProjetoBase.Models;
using System.Diagnostics;

namespace ProjetoBase.Controllers
{
    public class DespesaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IActionResult CriarDespesa()
        {
            return View("CriarDespesa");
        }
    }
}
