using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Entities
{
    public class TranscribeEntity : BaseEntity
    {
        public string? nome { get; set; }
        public string? caminho { get; set; }
        public string? duracao { get; set; }
        
    }
}
