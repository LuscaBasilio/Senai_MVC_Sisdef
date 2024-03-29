﻿using System;
using System.Collections.Generic;

namespace Senai.SAEP.Sisdef.Domains
{
    public partial class Defeito
    {
        public Defeito()
        {
            RegistroDefeito = new HashSet<RegistroDefeito>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<RegistroDefeito> RegistroDefeito { get; set; }
    }
}
