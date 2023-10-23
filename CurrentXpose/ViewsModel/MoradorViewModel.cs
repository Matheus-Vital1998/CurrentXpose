﻿using System.ComponentModel.DataAnnotations;

namespace CurrentXpose.ViewsModel
{
    public class MoradorViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
