using AutoMapper;

using Lab9.App.DAL.Entities;

using Renting.Server.Dtos;

namespace Renting.Server.AutoMapperProfiles
{
    public class RentProfile : Profile
    {
        public RentProfile()
        {
            CreateMap<Rent, RentDto>(MemberList.Destination).ReverseMap();
        }
    }
}
