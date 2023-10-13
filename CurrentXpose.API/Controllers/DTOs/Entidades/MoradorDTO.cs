﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentXpose.Domain.Entidades
{
    public class MoradorDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string  login { get; set; }
        public string senha { get; set; }
        public ResidenciaDTO residencia { get; set; }

        public MoradorDTO() { }
    }
}
