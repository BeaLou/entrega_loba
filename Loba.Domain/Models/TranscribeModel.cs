using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Models
{
    public class TranscribeModel: BaseModel
    {

        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string? _nome { get; set; }
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string? _caminho { get; set; }

        public string caminho
        {
            get { return _caminho; }
            set { _caminho = value; }
        }
    
        private string? _duracao { get; set; }
        public string duracao
        {
            get { return _duracao; }
            set { _duracao = value; }
        }        
    }
}
