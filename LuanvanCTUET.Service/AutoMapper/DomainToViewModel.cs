using AutoMapper;
using LuanvanCTUET.Data.Entity;
using LuanvanCTUET.Service.ViewModel.Product;

namespace LuanvanCTUET.Service.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Category, CategoryViewModel>();
        }
    }
}