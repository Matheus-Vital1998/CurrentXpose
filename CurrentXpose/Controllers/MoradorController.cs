using CurrentXpose.Models; 
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class MoradorController : Controller
    {
        public IActionResult Inicial()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Historico(FiltrosViewModel filtros)
        {
            return View(filtros);
        }
    }
}