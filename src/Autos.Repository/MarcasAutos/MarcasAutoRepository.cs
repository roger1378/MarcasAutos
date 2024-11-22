using Autos.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Autos.Repository.MarcasAutos;

public class MarcasAutoRepository : IMarcasAutoRepository
{
    private readonly AutosMarcasDbContext _autosMarcasDbContext;

    public MarcasAutoRepository(AutosMarcasDbContext autosMarcasDbContext)
    {
        _autosMarcasDbContext = autosMarcasDbContext;
    }

    public async Task<IEnumerable<MarcasAuto>> GetAsync()
    {
        return await _autosMarcasDbContext.MarcasAutos
            .Where(marcasAuto => marcasAuto.IsActive)
            .ToListAsync();
    }
}
