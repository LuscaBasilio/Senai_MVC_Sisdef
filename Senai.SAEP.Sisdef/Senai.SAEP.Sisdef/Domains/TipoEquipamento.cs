﻿using System;
using System.Collections.Generic;

namespace Senai.SAEP.Sisdef.Domains
{
    public partial class TipoEquipamento
    {
        public TipoEquipamento()
        {
            Equipamento = new HashSet<Equipamento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Equipamento> Equipamento { get; set; }
    }
}
