using AutoMapper;
using GaragemApi.Data.Dtos;

namespace GaragemApi.Profiles;

public class VeiculoProfile : Profile
{
    public VeiculoProfile()
    {
        CreateMap<CreateVeiculoDto, Veiculo>();
        CreateMap<Veiculo, ReadVeiculoDto>();
        CreateMap<UpdateVeiculoDto, Veiculo>();
    }
}
