using Loba.Domain.Entities;
using Loba.Domain.Repository;
using Loba.Infrastructure.Data.Context;
using Loba.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.Data.Implementations
{
    public class UsuarioAudioTextoImplementation : BaseRepository<UsuarioAudioTextoEntity>, IUsuarioAudioTextoRepository
    {
        private DbSet<UsuarioAudioTextoEntity> _dataset;

        public UsuarioAudioTextoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<UsuarioAudioTextoEntity>();
        }
    }
}
