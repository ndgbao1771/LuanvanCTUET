using LuanvanCTUET.Data.Enum;
using LuanvanCTUET.Data.Interface;
using LuanvanCTUET.Infrastructure.SharedKernel;
using System;

namespace LuanvanCTUET.Data.Entity
{
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSEOMetaData
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        public int? ViewCount { get; set; }
        public string Tags { get; set; }
        public string Unit { get; set; }

        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoPageDescription { get; set; }

        public virtual Category Category { get; set; }
    }
}