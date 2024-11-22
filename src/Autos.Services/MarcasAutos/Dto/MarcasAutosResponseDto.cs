namespace Autos.Services.MarcasAutos.Dto;

public class MarcasAutosResponseDto
{
    public Guid Id { get; set; }

    public string Marca { get; set; }

    public string Modelo { get; set; }

    public int Anno { get; set; }

    public string Color { get; set; }

    public bool IsActive { get; set; }

    public string Serial { get; set; }
}
