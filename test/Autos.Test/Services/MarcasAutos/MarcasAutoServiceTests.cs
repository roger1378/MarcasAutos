using AutoMapper;
using Autos.Repository.MarcasAutos;
using Autos.Repository.Models;
using Autos.Services.MarcasAutos;
using Autos.Services.MarcasAutos.Mapping;
using Autos.Test.Builders;
using Moq;

namespace Autos.Test.Services.MarcasAutos;

public class MarcasAutoServiceTests
{
    private readonly IMapper _mapper;
    private readonly Mock<IMarcasAutoRepository> _marcasAutoRepositoryMock;
    private readonly MarcasAutoService _marcasAutoService;

    public MarcasAutoServiceTests()
    {
        var mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new AutosMarcaMapping());
        });
        _mapper = mapperConfiguration.CreateMapper();

        _marcasAutoRepositoryMock = new Mock<IMarcasAutoRepository>();

        _marcasAutoService = new MarcasAutoService(
            _mapper,
            _marcasAutoRepositoryMock.Object);
    }

    [Fact]
    public async Task GetAsync_WhenRequested_ShouldReturnAllMarcasAutos()
    {
        var marcasAuto = MarcasAutoBuilder.Builder()
            .WithMarca("Ford")
            .Build();

        var expectedMarcasAutos = new List<MarcasAuto> { marcasAuto };

        _marcasAutoRepositoryMock
            .Setup(repository => repository.GetAsync())
            .ReturnsAsync(expectedMarcasAutos);

        // ACT
        var activeMarcasAutos = await _marcasAutoService.GetAsync();

        // ASSERT
        Assert.NotNull(activeMarcasAutos);
        Assert.Single(activeMarcasAutos);
        Assert.Equal(marcasAuto.Marca, activeMarcasAutos.First().Marca);
    }
}
