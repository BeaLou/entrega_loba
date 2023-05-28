using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Models
{
    public class UsuarioModel: BaseModel
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
        private string? _senha { get; set; }

        public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        private string? _email { get; set; }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
