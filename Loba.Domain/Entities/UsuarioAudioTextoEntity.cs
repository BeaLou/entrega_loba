using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Entities
{
    public class UsuarioAudioTextoEntity: BaseEntity
    {
        public int idUsuario { get; set; }
        public int idArquivoAudio { get; set; }
        public int idArquivoTexto { get; set; }

        public List<TranscribeEntity> transcricoes{ get; set; }
        public List<AtaEntity> atas{ get; set; }
        public List<UsuarioEntity> usuarios{ get; set; }
    }
}
