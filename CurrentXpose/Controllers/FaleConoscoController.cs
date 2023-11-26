using CurrentXpose.Domain.Entidades;
using CurrentXpose.Domain.Interface;
using CurrentXpose.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurrentXpose.Controllers
{
    [Authorize]
    public class FaleConoscoController : Controller
    {
        private readonly IEmailService _emailService;

        public FaleConoscoController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public IActionResult FaleConosco()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FaleConosco(FaleConosco model)
        {
            if (ModelState.IsValid)
            {
                await _emailService.EnviarMensagemFaleConosco(model);

                return RedirectToAction("Sucesso");
            }
            return View(model);
        }

        public IActionResult Sucesso()
        {
            return View();
        }
    }
}