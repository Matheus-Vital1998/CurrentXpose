using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    [Authorize]
    public class EconomiaController : Controller
    {
        public IActionResult Economia()
        {
            return View();
        }
        public IActionResult EconomiaSindico()
        {
            return View();
        }
    }
}
