using Loba.Domain.Dtos.Ata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Interfaces.Services.Ata
{
    public interface IAtaService
    {
        Task<AtaDto> Get(int id);
        Task<IEnumerable<AtaDto>> GetAll();
        Task<AtaDto> Post(AtaDtoCreateRequest ataDtoCreateRequest);
        Task<AtaDto> Put(AtaDtoUpdateRequest ataDtoUpdateRequest);
        Task<bool> Delete(int id);
    }
}

