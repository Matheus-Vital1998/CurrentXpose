using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class Leitura
    {
        public DateTime Data_Leitura { get; set; }
        public double Valor { get; set; }
        public Residencia Residencia { get; set; }

        public Leitura() { }
    }
}
