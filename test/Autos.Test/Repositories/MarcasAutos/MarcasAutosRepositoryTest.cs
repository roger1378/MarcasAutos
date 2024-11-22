using Autos.Repository.MarcasAutos;
using Autos.Repository.Models;
using Autos.Test.Builders;
using FluentAssertions;
using Orders.Test.Helpers;

namespace Orders.Test.Repositories.Products;

public class ProductRepositoryTests
{
    [Fact]
    public async Task GetAsync_WhenRequested_ShouldReturnAllActiveProducts()
    {
        var marcasAuto = MarcasAutoBuilder.Builder()
            .Build();

        var dbContext = await SeededPaymentOrdersDbContext
            .BuildPaymentOrdersDbContextAsync(new MarcasAuto[] { marcasAuto });

        var repository = new MarcasAutoRepository(dbContext);

        // ACT
        var actualMarcasAuto = await repository.GetAsync();
        var expectedMarcasAUto = new MarcasAuto[] { marcasAuto };

        // ASSERT
        expectedMarcasAUto.Should().Equal(actualMarcasAuto);
    }
}
