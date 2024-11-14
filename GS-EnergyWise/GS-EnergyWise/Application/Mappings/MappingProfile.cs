using AutoMapper;
using GS_EnergyWise.Application.DOTs;
using GS_EnergyWise.Domain.Entities;

namespace GS_EnergyWise.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ComunidadeEntity, ComunidadeDTO>().ReverseMap();
    }
}