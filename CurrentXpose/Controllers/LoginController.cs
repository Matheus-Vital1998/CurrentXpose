using CurrentXpose.ApiService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    public class LoginController : Controller
    {
        public readonly IAuthApiService _authApiService;

        public LoginController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Login(string username, string senha)
        {
            if (username == "admin" && senha == "admin")
            {
                await _authApiService.Autenticar(username, senha);
                Console.WriteLine("Redirecionando para Sindico");
                return RedirectToAction("Sindico", "Sindico");
            }

             await _authApiService.Autenticar(username, senha);
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
