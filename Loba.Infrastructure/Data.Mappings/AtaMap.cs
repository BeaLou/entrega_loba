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
    public class AtaMap : IEntityTypeConfiguration<AtaEntity>
    {
        public void Configure(EntityTypeBuilder<AtaEntity> builder)
        {
            builder.ToTable("AtaTexto");

            builder.HasKey(p => p.id);
            builder.Property(p => p.nome)
                   .HasMaxLength(100);
            builder.Property(u => u.tamanho);
            builder.Property(u => u.caminho);
            builder.Property(u => u.textoTranscricao);

        }
    }
}
