using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Dtos.Usuario
{
    public class UsuarioDtoUpdateResponse
    {
        public int id { get; set; }
        public DateTime? dataInclusao { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public string? senha { get; set; }
        public bool excluido { get; set; }

    }
}
