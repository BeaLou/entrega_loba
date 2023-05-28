using Loba.Domain.Interfaces.Services.Ata;
using Loba.Domain.Interfaces.Services.UsuarioAudioTexto;
using Loba.Domain.Interfaces.Transcribe;
using Loba.Domain.Interfaces.Usuario;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ITranscribeService, TranscribeService>();            
            serviceCollection.AddTransient<IAtaService, AtaService>();            
            serviceCollection.AddTransient<IUsuarioService,UsuarioService>();            
            serviceCollection.AddTransient<IUsuarioAudioTextoService, UsuarioAudioTextoService>();            
        }
    }
}
