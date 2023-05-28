using Loba.Domain.Entities;
using Loba.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Repository
{
    public interface IUsuarioRepository: IRepository<UsuarioEntity>
    {
        Task<UsuarioEntity> SelectAsync(string email);
        Task<UsuarioEntity> SelectAsync(string email, string senha);

    }
}
