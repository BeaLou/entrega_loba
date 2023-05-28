using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int id { get; set; }
        public DateTime? dataInclusao { get; set; }       
        public DateTime? dataAlteracao { get; set; }
        public bool excluido { get; set; }
    }
}
