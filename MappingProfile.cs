using AutoMapper;
using SocialNetwork.Models.Db;
using SocialNetwork.Views;
using System;

namespace SocialNetwork
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// В конструкторе настроим соответствие сущностей при маппинге
        /// </summary>
        public MappingProfile()
        {
            CreateMap<RegisterViewModel, User>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.FirstName))
                 .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => new DateTime(src.Year, src.Month, src.Date)))
                 .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.EmailReg));



        }
    }
}
