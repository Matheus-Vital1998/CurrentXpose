using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class Predio
    {
        public int Id { get; set; }
        public int Andares { get; set; }
        public string Name { get; set; }
        public Condominio condominio { get; set; }

        public Predio() { }
    }
}
