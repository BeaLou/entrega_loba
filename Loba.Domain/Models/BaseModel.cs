using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Models
{
    public class BaseModel
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _dataInclusao;
        public DateTime dataInclusao
        {
            get { return _dataInclusao; }
            set { _dataInclusao = value == null ? DateTime.UtcNow : value; }
        }

        private DateTime _dataAlteracao;
        public DateTime dataAlteracao
        {
            get { return _dataAlteracao; }
            set { _dataAlteracao = value == null ? DateTime.UtcNow : value; }
        }

        private int _excluido;
        public int excluido
        {
            get { return _excluido; }
            set { _excluido = value; }
        }
    }
}
