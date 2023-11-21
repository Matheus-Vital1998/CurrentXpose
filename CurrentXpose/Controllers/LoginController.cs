using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string senha)
        {
            if (username == "admin" && senha == "admin")
            {
                Console.WriteLine("Redirecionando para Sindico");
                return RedirectToAction("Sindico", "Sindico");
            }

            Console.WriteLine("Redirecionando para Inicial");
            return RedirectToAction("Inicial", "Morador");
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
