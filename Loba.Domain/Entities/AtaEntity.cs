using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Entities
{
    public class AtaEntity: BaseEntity
    {
        public string? nome { get; set; }
        public string? caminho { get; set; }
        public string? tamanho { get; set; }
        public string? textoTranscricao { get; set; }

    }
}
