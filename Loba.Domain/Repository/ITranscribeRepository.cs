using Loba.Domain.Entities;
using Loba.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Repository
{
    public interface ITranscribeRepository : IRepository<TranscribeEntity>
    {
        Task<TranscribeEntity> SelectAsync(string nome);

    }
}
