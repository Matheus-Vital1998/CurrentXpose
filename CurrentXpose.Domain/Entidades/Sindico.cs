using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class Sindico
    {
        public Morador sindico { get; set; }
        public string Relatorios { get; set; }

        public Sindico() { }
    }
}
