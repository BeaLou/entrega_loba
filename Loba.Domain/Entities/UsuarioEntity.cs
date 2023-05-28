using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Entities
{
    public class UsuarioEntity: BaseEntity
    {
        public string? nome { get; set; }
        public string? email { get; set; }
        public string? senha { get; set; }
    }
}
