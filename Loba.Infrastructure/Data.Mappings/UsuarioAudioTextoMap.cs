using Loba.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.Data.Mappings
{
    public class UsuarioAudioTextoMap : IEntityTypeConfiguration<UsuarioAudioTextoEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioAudioTextoEntity> builder)
        {
            builder.ToTable("UsuarioAudioTexto");

            builder.HasKey(p => p.id);
            builder.HasMany(p => p.atas).WithOne();
            builder.HasMany(p => p.transcricoes).WithOne();
            builder.HasMany(p => p.usuarios).WithOne();
        }
    }
}
