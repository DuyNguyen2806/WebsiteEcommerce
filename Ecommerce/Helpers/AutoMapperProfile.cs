using AutoMapper;
using Ecommerce.Data;
using Ecommerce.ViewModel;

namespace Ecommerce.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<RegisterVM, KhachHang>();
        }
    }
}
