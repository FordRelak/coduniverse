using Coduniverse.Domain;
using Coduniverse.Infrastructure.Abstractions;
using Coduniverse.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Coduniverse.Infrastructure.Extentions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrasctuctureEf(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfDbContext>(o => o.UseNpgsql(configuration.GetConnectionString("PosgresConnectionString"))
                                                     .EnableSensitiveDataLogging());
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWorkRepository, UOWRepository>();
            return services;
        }
    }
}