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
    public class TranscribeImplementation : BaseRepository<TranscribeEntity>, ITranscribeRepository
    {
        private DbSet<TranscribeEntity> _dataset;

        public TranscribeImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<TranscribeEntity>();
        }


        public async Task<TranscribeEntity> SelectAsync(string nome)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.nome.Equals(nome));
        }
    }
}
