using AutoMapper;
using SocialNetwork.Models.Db;
using SocialNetwork.Views;

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
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.LastName));


           
        }
    }
}
