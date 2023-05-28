using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Models
{
    public class UsuarioAudioTextoModel: BaseModel
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string? _idArquivoAudio { get; set; }
        public string idArquivoAudio
        {
            get { return _idArquivoAudio; }
            set { _idArquivoAudio = value; }
        }
        private string? _idArquivoTexto { get; set; }

        public string idArquivoTexto
        {
            get { return _idArquivoTexto; }
            set { _idArquivoTexto = value; }
        }

        private string? _idUsuario { get; set; }
        public string idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
    }
}
