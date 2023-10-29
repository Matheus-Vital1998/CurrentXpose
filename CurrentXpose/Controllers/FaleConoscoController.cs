using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class FaleConoscoController : Controller
    {
        public IActionResult FaleConosco()
        {
            return View();
        }
    }
}
