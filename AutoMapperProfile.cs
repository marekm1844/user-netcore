using AutoMapper;
using user_netcore.Dtos;
using user_netcore.Models;

namespace user_netcore
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, GetUserDto>();
        }
    }
}