using AutoMapper;
using Loba.Domain.Dtos.UsuarioAudioTexto;
using Loba.Domain.Entities;
using Loba.Domain.Interfaces;
using Loba.Domain.Interfaces.Services.UsuarioAudioTexto;
using Loba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.DependencyInjection
{
    public class UsuarioAudioTextoService : IUsuarioAudioTextoService
    {
        private IRepository<UsuarioAudioTextoEntity> _usuarioAudioTextoRepository;
        private readonly IMapper _mapper;

        public UsuarioAudioTextoService(IRepository<UsuarioAudioTextoEntity> usuarioAudioTextoRepository, IMapper mapper)
        {
            _usuarioAudioTextoRepository = usuarioAudioTextoRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _usuarioAudioTextoRepository.DeleteAsync(id);
        }

        public async Task<UsuarioAudioTextoDto> Get(int id)
        {
            var entity = await _usuarioAudioTextoRepository.SelectAsync(id);
            return _mapper.Map<UsuarioAudioTextoDto>(entity);
        }

        public async Task<IEnumerable<UsuarioAudioTextoDto>> GetAll()
        {
            var listEntity = await _usuarioAudioTextoRepository.SelectAsync();
            return _mapper.Map<IEnumerable<UsuarioAudioTextoDto>>(listEntity);
        }

        public async Task<UsuarioAudioTextoDto> Post(UsuarioAudioTextoDtoCreateRequest UsuarioAudioTexto)
        {
            var model = _mapper.Map<UsuarioAudioTextoModel>(UsuarioAudioTexto);
            var entity = _mapper.Map<UsuarioAudioTextoEntity>(model);
            var result = await _usuarioAudioTextoRepository.InsertAsync(entity);

            return _mapper.Map<UsuarioAudioTextoDto>(result);
        }

        public async Task<UsuarioAudioTextoDto> Put(UsuarioAudioTextoDtoUpdateRequest UsuarioAudioTexto)
        {
            var model = _mapper.Map<UsuarioAudioTextoModel>(UsuarioAudioTexto);
            var entity = _mapper.Map<UsuarioAudioTextoEntity>(model);
            var result = await _usuarioAudioTextoRepository.UpdateAsync(entity);

            return _mapper.Map<UsuarioAudioTextoDto>(result);
        }

    }
}
