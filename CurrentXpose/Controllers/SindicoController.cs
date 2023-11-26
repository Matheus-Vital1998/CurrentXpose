using CurrentXpose.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    [Authorize]
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
