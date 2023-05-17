using AutoMapper;
using Core;
using Dtos;

namespace ExSupplyContrl
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderInputDto>().ReverseMap();
            CreateMap<Order, OrderOutputDto>().ReverseMap();
        }
    }
}
