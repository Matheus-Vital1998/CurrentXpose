using CurrentXpose.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class ResidenciaDTO
    {
        public int id { get; set; }
        public string numero { get; set; }
        public string andar { get; set; }
        public PredioDTO predio { get; set; }

        public ResidenciaDTO() { }
    }
}
