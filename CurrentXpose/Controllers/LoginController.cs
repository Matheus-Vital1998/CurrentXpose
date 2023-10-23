using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
