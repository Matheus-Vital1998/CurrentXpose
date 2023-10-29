using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult TrocarSenha()
        {
            return View();
        }

        public IActionResult Logout() 
        {
            return View();
        }
    }
}
