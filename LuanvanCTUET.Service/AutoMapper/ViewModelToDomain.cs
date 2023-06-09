using AutoMapper;
using LuanvanCTUET.Data.Entity;
using LuanvanCTUET.Service.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanvanCTUET.Service.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain() 
        {
            CreateMap<CategoryViewModel, Category>().ConstructUsing(c => new Category(
                c.Name, c.Description, c.ParentId, c.HomeOrder, c.Image, 
                c.HomeFlag, c.SortOrder, c.Status, c.SeoPageTitle, 
                c.SeoAlias, c.SeoKeyword, c.SeoPageDescription));
        }
    }
}
