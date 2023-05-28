using AutoMapper;
using Loba.Domain.Entities;
using Loba.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<TranscribeModel, TranscribeEntity>()
                .ReverseMap(); 
            CreateMap<AtaModel, AtaEntity>()
                .ReverseMap();
            CreateMap<UsuarioModel, UsuarioEntity>()
               .ReverseMap();
            CreateMap<UsuarioAudioTextoModel, UsuarioAudioTextoEntity>()
               .ReverseMap();
        }
    }
}
