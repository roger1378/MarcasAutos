using Autos.Repository.Models;

namespace Autos.Repository.MarcasAutos;

public interface IMarcasAutoRepository
{
    Task<IEnumerable<MarcasAuto>> GetAsync();
}
