using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class PredioDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int total_de_andares { get; set; }
        public CondominioDTO condominio { get; set; }

        public PredioDTO() { }
    }
}
