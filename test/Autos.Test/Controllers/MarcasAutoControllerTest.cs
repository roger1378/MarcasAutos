using Autos.Api.Controllers;
using Autos.Services.MarcasAutos;
using Autos.Services.MarcasAutos.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Orders.Test.Controllers;

public class MarcasAutosControllerTests
{
    private readonly Mock<IMarcasAutoService> _mockMarcasAutoService;
    private readonly MarcasAutosController _controller;

    public MarcasAutosControllerTests()
    {
        _mockMarcasAutoService = new Mock<IMarcasAutoService>();
        _controller = new MarcasAutosController(_mockMarcasAutoService.Object);
    }

    [Fact]
    public async Task GetAsync_ReturnsOkResult_WithListOfMarcasAutos()
    {
        // Arrange
        var marcasAutos = new List<MarcasAutosResponseDto>
        {
            new MarcasAutosResponseDto { Id = Guid.NewGuid(), Marca = "Toyota", Modelo = "Rav4", Anno = 2024, Color = "Blanco", IsActive = true, Serial = "1234567890" },
            new MarcasAutosResponseDto { Id = Guid.NewGuid(), Marca = "Ford", Modelo = "Ranger", Anno = 2025, Color = "Azul", IsActive = true, Serial = "12345678" }
        };
        _mockMarcasAutoService.Setup(service => service.GetAsync()).ReturnsAsync(marcasAutos);

        // Act
        var result = await _controller.GetAsync();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsType<List<MarcasAutosResponseDto>>(okResult.Value);
        Assert.Equal(2, returnValue.Count);
    }
}
