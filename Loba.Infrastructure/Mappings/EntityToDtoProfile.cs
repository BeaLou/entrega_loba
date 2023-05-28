using AutoMapper;
using Loba.Domain.Dtos.Ata;
using Loba.Domain.Dtos.Transcribe;
using Loba.Domain.Dtos.Usuario;
using Loba.Domain.Dtos.UsuarioAudioTexto;
using Loba.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<TranscribeDto, TranscribeEntity>()
                .ReverseMap(); 
            
            CreateMap<AtaDto, AtaEntity>()
                .ReverseMap();

            CreateMap<UsuarioDto, UsuarioEntity>()
                .ReverseMap();
            
            CreateMap<UsuarioAudioTextoDto, UsuarioAudioTextoEntity>()
                .ReverseMap();
        }
    }
}
