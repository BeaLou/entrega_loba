using AutoMapper;
using Loba.Domain.Dtos.Ata;
using Loba.Domain.Dtos.Transcribe;
using Loba.Domain.Dtos.Usuario;
using Loba.Domain.Dtos.UsuarioAudioTexto;
using Loba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<TranscribeModel, TranscribeDto>()
                .ReverseMap();

            CreateMap<TranscribeModel, TranscribeDtoCreateRequest>()
                .ReverseMap();

            CreateMap<TranscribeModel, TranscribeDtoUpdateRequest>()
                .ReverseMap();

            CreateMap<AtaModel, AtaDto>()
                .ReverseMap();

            CreateMap<AtaModel, AtaDtoCreateRequest>()
                .ReverseMap();

            CreateMap<AtaModel, AtaDtoUpdateRequest>()
                .ReverseMap();

            CreateMap<UsuarioModel, UsuarioDto>()
               .ReverseMap();

            CreateMap<UsuarioModel, UsuarioDtoCreateRequest>()
                .ReverseMap();

            CreateMap<UsuarioModel, UsuarioDtoUpdateRequest>()
                .ReverseMap();

            CreateMap<UsuarioAudioTextoModel, UsuarioAudioTextoDto>()
               .ReverseMap();

            CreateMap<UsuarioAudioTextoModel, UsuarioAudioTextoDtoCreateRequest>()
                .ReverseMap();

            CreateMap<UsuarioAudioTextoModel, UsuarioAudioTextoDtoUpdateRequest>()
                .ReverseMap();

        }
    }
}
