using Loba.Domain.Entities;
using Loba.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<TranscribeEntity> TranscribeEntities { get; set;}
        public DbSet<AtaEntity> AtaEntity { get; set;}
        public DbSet<UsuarioEntity> UsuarioEntity { get; set;}
        public DbSet<UsuarioAudioTextoEntity> UsuarioAudioTextoEntity { get; set;}

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TranscribeEntity>(new TranscribeMap().Configure);
            modelBuilder.Entity<AtaEntity>(new AtaMap().Configure);
            modelBuilder.Entity<UsuarioEntity>(new UsuarioMap().Configure);
            modelBuilder.Entity<UsuarioAudioTextoEntity>(new UsuarioAudioTextoMap().Configure);


            modelBuilder.Entity<TranscribeEntity>().HasData(
            new TranscribeEntity
            {
                id = -1,
                nome = "PrimeiroArquivo",
                dataInclusao = DateTime.Now,
                dataAlteracao = DateTime.Now,
                excluido = false,
                duracao = "1:00:10",
                caminho = "c:\\teste\\teste",
            }
          );
            
            modelBuilder.Entity<AtaEntity>().HasData(
            new AtaEntity
            {
                id = -1,
                nome = "PrimeiroArquivo",
                dataInclusao = DateTime.Now,
                dataAlteracao = DateTime.Now,
                excluido = false,
                tamanho = "50mb",
                caminho = "c:\\teste\\teste",
                textoTranscricao = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"

            }
          );

            modelBuilder.Entity<UsuarioEntity>().HasData(
           new UsuarioEntity
           {
               id = -1,
               nome = "Bea",
               dataInclusao = DateTime.Now,
               dataAlteracao = DateTime.Now,
               excluido = false,
               email = "bea@bea.com",
               senha = "123",
           }
         );

            modelBuilder.Entity<UsuarioAudioTextoEntity>().HasData(
           new UsuarioAudioTextoEntity
           {
               id = -1,
               idUsuario = -1,
               dataInclusao = DateTime.Now,
               dataAlteracao = DateTime.Now,
               excluido = false,
               idArquivoAudio = -1,
               idArquivoTexto = -1,
           }
         );

        }
    }
}
