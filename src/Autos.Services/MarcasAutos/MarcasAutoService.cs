using AutoMapper;
using Autos.Repository.MarcasAutos;
using Autos.Services.MarcasAutos.Dto;

namespace Autos.Services.MarcasAutos;

public class MarcasAutoService : IMarcasAutoService
{
    private readonly IMapper _mapper;
    private readonly IMarcasAutoRepository _marcasAutoRepository;

    public MarcasAutoService(IMapper mapper, IMarcasAutoRepository marcasAutoRepository)
    {
        _mapper = mapper;
        _marcasAutoRepository = marcasAutoRepository;
    }

    public async Task<IEnumerable<MarcasAutosResponseDto>> GetAsync()
    {
        return _mapper.Map<IEnumerable<MarcasAutosResponseDto>>(
            await _marcasAutoRepository.GetAsync());
    }
}
