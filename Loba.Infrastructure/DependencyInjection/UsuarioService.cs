using AutoMapper;
using Loba.Domain.Dtos.Usuario;
using Loba.Domain.Entities;
using Loba.Domain.Interfaces;
using Loba.Domain.Interfaces.Usuario;
using Loba.Domain.Models;
using Loba.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.DependencyInjection
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _usuarioRepository.DeleteAsync(id);
        }

        public async Task<UsuarioDto> Get(int id)
        {
            var entity = await _usuarioRepository.SelectAsync(id);
            return _mapper.Map<UsuarioDto>(entity);
        }
        public async Task<UsuarioDto> Get(string email)
        {
            var entity = await _usuarioRepository.SelectAsync(email);
            return _mapper.Map<UsuarioDto>(entity);
        }

        public async Task<UsuarioDto> Get(string email, string senha)
        {
            var entity = await _usuarioRepository.SelectAsync(email);
            return _mapper.Map<UsuarioDto>(entity);
        }
        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            var listEntity = await _usuarioRepository.SelectAsync();
            return _mapper.Map<IEnumerable<UsuarioDto>>(listEntity);
        }

        public async Task<UsuarioDto> Post(UsuarioDtoCreateRequest Usuario)
        {
            var model = _mapper.Map<UsuarioModel>(Usuario);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _usuarioRepository.InsertAsync(entity);

            return _mapper.Map<UsuarioDto>(result);
        }

        public async Task<UsuarioDto> Put(UsuarioDtoUpdateRequest Usuario)
        {
            var model = _mapper.Map<UsuarioModel>(Usuario);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _usuarioRepository.UpdateAsync(entity);

            return _mapper.Map<UsuarioDto>(result);
        }
    }
}
