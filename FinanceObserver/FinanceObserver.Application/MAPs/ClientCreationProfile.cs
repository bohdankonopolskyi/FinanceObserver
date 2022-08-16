using AutoMapper;
using FinanceObserver.Application.DTO;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.MAPs;

public class ClientCreationProfile : Profile
{
    public ClientCreationProfile()
    {
        CreateMap<ClientForCreationDto, Client>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.AuthenticationToken, opt => opt.MapFrom(src => src.Name));
    }
}