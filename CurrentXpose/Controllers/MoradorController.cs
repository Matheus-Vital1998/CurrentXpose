using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class MoradorController : Controller
    {
        public IActionResult Inicial()
        {
            return View();
        }

        public IActionResult Historico()
        {
            return View();
        }
    }
}
