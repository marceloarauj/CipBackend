using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEscolar.Database;
using ProjetoEscolar.Repository;
using ProjetoEscolar.Services;

namespace ProjetoEscolar.Configurations
{
    public class InjectConfig
    {
        public static void Registrar(IServiceCollection services, IConfiguration configuration){
            
            #region Services
            services.AddTransient<RegisterService>();
            #endregion

            #region Repositories
            services.AddTransient<RegisterRepository>();
            #endregion
            services.AddEntityFrameworkNpgsql().AddDbContext<Context>
                (options =>options.UseNpgsql(configuration.GetConnectionString("CipDB")));
        }
    }
}