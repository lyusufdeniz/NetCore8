using App.Repositories.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Repositories.Extensions
{
    //Creating Extension Method 
    public static class RepositoryExtension
    {

        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => {
                var connectionStrings = configuration.GetSection(ConnectionStringOptions.Key).Get<ConnectionStringOptions>();

                options.UseSqlServer(connectionStrings!.SQLServer, sqlServerOptionsAction =>
                {
                    //migrationların  appdbcontextin bulunduğu projeye eklenmesini istiyoruz
                    sqlServerOptionsAction.MigrationsAssembly(typeof(RepositoryAssembly).Assembly.FullName);
                });
            }
        

);
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //dönüş tipi void de olabilirdli ama program.csde cagirdiktan sonra builder.Services.AddRepositories(builder.Configuration) diyip sonuna notka koyup devam edilebilir IServiceCollection olunca yani builder.Services.AddRepositories(builder.Configuration).AddXX().AddYY gibi;
            return services;
        }
    }
}
