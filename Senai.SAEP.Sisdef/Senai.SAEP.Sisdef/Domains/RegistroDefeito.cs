using System;
using System.Collections.Generic;

namespace Senai.SAEP.Sisdef.Domains
{
    public partial class RegistroDefeito
    {
        public int Id { get; set; }
        public DateTime? DataDefeito { get; set; }
        public int? EquipamentoId { get; set; }
        public int? TipoDefeitoId { get; set; }
        public DateTime? HoraInicial { get; set; }
        public DateTime? HoraFinal { get; set; }

        public Equipamento Equipamento { get; set; }
        public Defeito TipoDefeito { get; set; }
    }
}
