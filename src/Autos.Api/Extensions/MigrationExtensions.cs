using Autos.Repository;
using Microsoft.EntityFrameworkCore;

namespace Autos.Api.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using AutosMarcasDbContext dbContext =
            scope.ServiceProvider.GetRequiredService<AutosMarcasDbContext>();

        dbContext.Database.Migrate();
    }
}