using CurrentXpose.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    [Authorize]
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