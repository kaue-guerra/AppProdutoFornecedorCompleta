using AutoMapper;
using Dev.App.ViewModels;
using Dev.Business.Models;

namespace Dev.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Supplier, SupplierViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
        }

    }
}
