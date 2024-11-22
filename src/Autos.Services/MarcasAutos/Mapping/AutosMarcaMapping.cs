using AutoMapper;
using Autos.Repository.Models;
using Autos.Services.MarcasAutos.Dto;

namespace Autos.Services.MarcasAutos.Mapping;

public class AutosMarcaMapping : Profile
{
    public AutosMarcaMapping()
    {
        CreateMap<MarcasAuto, MarcasAutosResponseDto>()
            .ReverseMap();
    }
}
