using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Dtos.UsuarioAudioTexto
{
    public class UsuarioAudioTextoDto
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idArquivoAudio { get; set; }
        public int idArquivoTexto { get; set; }
        public DateTime? dataInclusao { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public bool excluido { get; set; }

    }
}
