using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class Condominio
    {
        public int Id { get; set; }
        public Sindico sindico { get; set; }
        public string Nome { get; set; }

        public Condominio() { }
    }
}
