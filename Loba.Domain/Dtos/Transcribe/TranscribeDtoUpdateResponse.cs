using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Dtos.Transcribe
{
    public class TranscribeDtoUpdateResponse
    {
        [Required(ErrorMessage = "Códido (id) é um campo obrigatorio")]
        public int id { get; set; }

        [Required(ErrorMessage = "Nome do Arquivo é um campo obrigatorio")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo 100 caracteres")]
        public string? nome { get; set; }
        public DateTime? dataInclusao { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public string? caminho { get; set; }
        public string? duracao { get; set; }
        public bool excluido { get; set; }

    }
}
