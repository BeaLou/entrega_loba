using Loba.Domain.Dtos.UsuarioAudioTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Interfaces.Services.UsuarioAudioTexto
{
    public interface IUsuarioAudioTextoService
    {
        Task<UsuarioAudioTextoDto> Get(int id);
        Task<IEnumerable<UsuarioAudioTextoDto>> GetAll();
        Task<UsuarioAudioTextoDto> Post(UsuarioAudioTextoDtoCreateRequest usuarioAudioTextoDtoCreateRequest);
        Task<UsuarioAudioTextoDto> Put(UsuarioAudioTextoDtoUpdateRequest usuarioAudioTextoDtoUpdateRequest);
        Task<bool> Delete(int id);
    }
}
