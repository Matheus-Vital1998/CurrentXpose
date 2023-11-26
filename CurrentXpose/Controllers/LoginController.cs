using CurrentXpose.ApiService.Interfaces;
using CurrentXpose.Domain.Entidades;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CurrentXpose.Controllers
{
    public class LoginController : Controller
    {
        public readonly IAuthApiService _authApiService;
        private readonly ILogger<LoginController> _logger;

        public LoginController(IAuthApiService authApiService, ILogger<LoginController> logger)
        {
            _authApiService = authApiService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string senha)
        {
            var resultMorador = await _authApiService.Autenticar(username, senha, "morador");
            var resultSindico = await _authApiService.Autenticar(username, senha, "sindico");

            if (resultMorador != null)
            {
                var token = JsonConvert.DeserializeObject<TokenResponse>(resultMorador.ToString());

                if (token != null)
                {
                    TempData["AccessToken"] = token.Token;

                    string tipoUsuario = ObterTipoUsuarioDoToken(token);

                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Hash, token.Token),
                        };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    switch (tipoUsuario)
                    {
                        case "Morador":
                            Console.WriteLine("Redirecionando para Inicial");
                            return Redirect("/Morador/Inicial");

                        default:
                            return RedirectToAction("Erro");
                    }
                }
            }

            else if (resultSindico != null)
            {
                var token = JsonConvert.DeserializeObject<TokenResponse>(resultSindico.ToString());

                if (token != null)
                {
                    TempData["AccessToken"] = token.Token;

                    string tipoUsuario = ObterTipoUsuarioDoToken(token);

                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Hash, token.Token),
                        };

                    var claimsIdentity = new ClaimsIdentity(
                   claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    switch (tipoUsuario)
                    {
                        case "Sindico":
                            Console.WriteLine("Redirecionando para Sindico");
                            return RedirectToAction("Sindico", "Sindico");

                        default:
                            return RedirectToAction("Erro");
                    }
                }
            }

            TempData["Status"] = "Usuário ou senha incorretos";
            return RedirectToAction("Index");
        }

        public IActionResult TrocarSenha()
        {
            return View();
        }

        public IActionResult Logout()
        {
            TempData.Remove("AccessToken");
            HttpContext.SignOutAsync();
            return Redirect("/Login/Index");
        }

        private string ObterTipoUsuarioDoToken(TokenResponse token)
        {
            return token.TipoUsuario;
        }
    }
}
