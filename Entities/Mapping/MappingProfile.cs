using AutoMapper;

using ShoppingControl.Entities.Dto;

namespace ShoppingControl.Entities.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Seller, SellerDto>()
                .ReverseMap();
        }

    }
}
