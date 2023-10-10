using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class Morador
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Login { get; set; }
        public string Senha { get; set; }

        public Morador() { }
    }
}
