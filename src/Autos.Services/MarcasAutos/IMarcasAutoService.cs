using Autos.Services.MarcasAutos.Dto;

namespace Autos.Services.MarcasAutos;

public interface IMarcasAutoService
{
    Task<IEnumerable<MarcasAutosResponseDto>> GetAsync();
}
