using CurrentXpose.Domain.Entidades;
using CurrentXpose.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CurrentXpose.Controllers
{
    [Authorize]
    public class SobreController : Controller
    {
        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult SobreSindico()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}