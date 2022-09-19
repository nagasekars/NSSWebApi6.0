using AutoMapper;

namespace NSS.WebAPI.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Models.Domain.Customer, Models.DTO.Customer>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id)).ReverseMap();
        }
    }
}
