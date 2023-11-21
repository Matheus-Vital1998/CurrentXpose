using CurrentXpose.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class SindicoController : Controller
    {
        public IActionResult Sindico()
        {
            return View();
        }

        public IActionResult Historico()
        {
            var filtroViewModel = new FiltrosViewModel();
            return View(filtroViewModel);
        }
    }
}
