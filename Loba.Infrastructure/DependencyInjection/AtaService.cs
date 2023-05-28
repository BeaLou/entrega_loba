using AutoMapper;
using Loba.Domain.Dtos.Ata;
using Loba.Domain.Entities;
using Loba.Domain.Interfaces;
using Loba.Domain.Interfaces.Services.Ata;
using Loba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.DependencyInjection
{
    public class AtaService : IAtaService
    {
        private IRepository<AtaEntity> _ataRepository;
        private readonly IMapper _mapper;

        public AtaService(IRepository<AtaEntity> ataRepository, IMapper mapper)
        {
            _ataRepository = ataRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _ataRepository.DeleteAsync(id);
        }

        public async Task<AtaDto> Get(int id)
        {
            var entity = await _ataRepository.SelectAsync(id);
            return _mapper.Map<AtaDto>(entity);
        }

        public async Task<IEnumerable<AtaDto>> GetAll()
        {
            var listEntity = await _ataRepository.SelectAsync();
            return _mapper.Map<IEnumerable<AtaDto>>(listEntity);
        }

        public async Task<AtaDto> Post(AtaDtoCreateRequest Ata)
        {
            var model = _mapper.Map<AtaModel>(Ata);
            var entity = _mapper.Map<AtaEntity>(model);
            var result = await _ataRepository.InsertAsync(entity);

            return _mapper.Map<AtaDto>(result);
        }

        public async Task<AtaDto> Put(AtaDtoUpdateRequest Ata)
        {
            var model = _mapper.Map<AtaModel>(Ata);
            var entity = _mapper.Map<AtaEntity>(model);
            var result = await _ataRepository.UpdateAsync(entity);

            return _mapper.Map<AtaDto>(result);
        }

    }
}
