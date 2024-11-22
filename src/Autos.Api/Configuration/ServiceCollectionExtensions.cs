using Autos.Repository.MarcasAutos;
using Autos.Services.MarcasAutos;
using Autos.Services.MarcasAutos.Mapping;

namespace Autos.Api.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMappers(
        this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutosMarcaMapping));

        return services;
    }

    public static IServiceCollection AddMyDependencyGroup(
         this IServiceCollection services)
    {
        //Repositories
        services.AddTransient<IMarcasAutoRepository, MarcasAutoRepository>();

        //Services
        services.AddTransient<IMarcasAutoService, MarcasAutoService>();

        return services;
    }
}
