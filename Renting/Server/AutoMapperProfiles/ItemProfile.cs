using AutoMapper;

using Lab9.App.DAL.Entities;

using Renting.Server.Dtos;

namespace Renting.Server.AutoMapperProfiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, ItemDto>(MemberList.Destination).ReverseMap();
        }
    }
}
