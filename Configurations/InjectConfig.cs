using Amazon.S3;
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
            services.AddTransient<FileService>();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddDefaultAWSOptions(configuration.GetAWSOptions("AWS"));
            services.AddAWSService<IAmazonS3>();
            #endregion

            #region Repositories
            services.AddTransient<RegisterRepository>();
            #endregion
            services.AddEntityFrameworkNpgsql().AddDbContext<Context>
                (options =>options.UseNpgsql(configuration.GetConnectionString("CipDB")));
        }
    }
}