using AutoMapper;

using Lab9.App.DAL.Entities;

using Renting.Server.Dtos;

namespace Renting.Server.AutoMapperProfiles
{
    public class PenaltyProfile : Profile
    {
        public PenaltyProfile()
        {
            CreateMap<Penalty, PenaltyDto>(MemberList.Destination).ReverseMap();
        }
    }
}
