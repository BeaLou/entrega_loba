using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Dtos.Ata
{
    public class AtaDtoCreateResponse
    {
        public int id { get; set; }
        public DateTime? dataInclusao { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public string? nome { get; set; }
        public string? caminho { get; set; }
        public string? tamanho { get; set; }
        public bool excluido { get; set; }
        public string? textoTranscricao { get; set; }

    }
}
