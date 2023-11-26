using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public string TipoUsuario { get; set; }
        public object Claims { get; set; }
        public object? AccessToken { get; set; }
    }
}
