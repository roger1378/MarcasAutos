using Autos.Repository;
using Microsoft.EntityFrameworkCore;

namespace Orders.Test.Helpers;

public static class SeededPaymentOrdersDbContext
{
    public static AutosMarcasDbContext
       BuildAutosMarcasDbContext()
    {
        var dbContext = new AutosMarcasDbContext(
            new DbContextOptionsBuilder<AutosMarcasDbContext>()
                .UseInMemoryDatabase($"ApplicationDb-{Guid.NewGuid():N}", configuration => configuration.UseHierarchyId())
                .Options);

        return dbContext;
    }

    public static AutosMarcasDbContext
       BuildPaymentOrdersDbContext(string databaseName)
    {
        var dbContext = new AutosMarcasDbContext(
            new DbContextOptionsBuilder<AutosMarcasDbContext>()
                .UseInMemoryDatabase(databaseName, configuration => configuration.UseHierarchyId())
                .Options);

        return dbContext;
    }

    public static async Task<AutosMarcasDbContext>
        BuildPaymentOrdersDbContextAsync<TEntity>(IEnumerable<TEntity> entities)
        where TEntity : class
    {
        var dbContext = BuildAutosMarcasDbContext();

        await dbContext.Set<TEntity>().AddRangeAsync(entities);
        await dbContext.SaveChangesAsync();

        return dbContext;
    }

    public static (AutosMarcasDbContext dbContext, string databaseName)
       BuildAutosMarcasDbContextWithDatabaseName()
    {
        var databaseName = $"ApplicationDb-{Guid.NewGuid():N}";
        var dbContext = new AutosMarcasDbContext(
            new DbContextOptionsBuilder<AutosMarcasDbContext>()
                .UseInMemoryDatabase(databaseName, configuration => configuration.UseHierarchyId())
                .Options);

        return (dbContext, databaseName);
    }
}
