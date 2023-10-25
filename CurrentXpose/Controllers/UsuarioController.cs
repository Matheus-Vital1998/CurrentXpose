using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Inicial()
        {
            return View();
        }
    }
}
