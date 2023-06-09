using LuanvanCTUET.Data.Enum;
using System.Collections.Generic;
using System;

namespace LuanvanCTUET.Service.ViewModel.Product
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool HomeFlag { get; set; }

        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoPageDescription { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public ICollection<ProductViewModel> ProductViewModel { get; set; }
    }
}