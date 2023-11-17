using CurrentXpose.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Interface
{
    public interface IEmailService
    {
        Task EnviarMensagemFaleConosco(FaleConosco model);
    }
}
