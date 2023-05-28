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
    public class UsuarioImplementation : BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        private readonly DbSet<UsuarioEntity> _dataset;

        public UsuarioImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<UsuarioEntity>();
        }

        public async Task<UsuarioEntity> SelectAsync(string email)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.email.Equals(email));
        } 
        
        public async Task<UsuarioEntity> SelectAsync(string email, string senha)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.email.Equals(email) && u.senha.Equals(senha));
        }
    }
}
