using Loba.Domain.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Interfaces.Usuario
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Get(int id);
        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioDto> Post(UsuarioDtoCreateRequest usuarioDtoCreateRequest);
        Task<UsuarioDto> Put(UsuarioDtoUpdateRequest usuarioDtoUpdateRequest);
        Task<bool> Delete(int id);

        Task<UsuarioDto> Get(string email);
        Task<UsuarioDto> Get(string email, string senha);

    }
}
