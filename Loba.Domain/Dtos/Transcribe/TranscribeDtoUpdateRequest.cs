using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Dtos.Transcribe
{
    public class TranscribeDtoUpdateRequest
    {
        public int id { get; set; }
        public DateTime? dataInclusao { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public string? nome { get; set; }
        public string? caminho { get; set; }
        public string? duracao { get; set; }
        public bool excluido { get; set; }

    }
}
