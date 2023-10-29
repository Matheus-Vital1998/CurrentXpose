using System.ComponentModel.DataAnnotations;

namespace CurrentXpose.Models
{
    public class TrocarSenhaViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string NovaSenha { get; set; }
        [Required]
        public string PerguntaSeguranca { get; set; }
        [Required]
        public string RespostaSeguranca { get; set; }
    }
}
