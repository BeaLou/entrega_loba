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
    public class AtaImplementation : BaseRepository<AtaEntity>, IAtaRepository
    {
        private DbSet<AtaEntity> _dataset;

        public AtaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<AtaEntity>();
        }
    }
}
