using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class SindicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
