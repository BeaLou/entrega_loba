using Loba.Domain.Interfaces;
using Loba.Domain.Repository;
using Loba.Infrastructure.Data.Context;
using Loba.Infrastructure.Data.Implementations;
using Loba.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Infrastructure.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<ITranscribeRepository, TranscribeImplementation>();
            serviceCollection.AddScoped<IAtaRepository, AtaImplementation>();
            serviceCollection.AddScoped<IUsuarioRepository, UsuarioImplementation>();
            serviceCollection.AddScoped<IUsuarioAudioTextoRepository, UsuarioAudioTextoImplementation>();
            serviceCollection.AddDbContext<MyContext>(options => options.UseMySql(Environment.GetEnvironmentVariable("Db_CONNECTION")));
        }
    }
}
