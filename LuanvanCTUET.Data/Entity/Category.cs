using LuanvanCTUET.Data.Enum;
using LuanvanCTUET.Data.Interface;
using LuanvanCTUET.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;

namespace LuanvanCTUET.Data.Entity
{
    public class Category : DomainEntity<int>, IHasSEOMetaData, ISwitchable, ISortable, IDateTracking
    {
        //Tạo ra 1 constructor như thế này để tránh trường hợp danh sách product bị null
        public Category() 
        {
            Products = new List<Product>();    
        }

        public Category(string name, string description, int? parentId, int? homeOrder, string image, bool homeFlag, int sortOrder, Status status,
            string seoPageTitle, string seoAlias, string seoKeyword, string seoPageDescription)
        {
            Name = name;
            Description = description;
            ParentId = parentId;
            HomeOrder = homeOrder;
            Image = image;
            HomeFlag = homeFlag;
            SortOrder = sortOrder;
            Status = status;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeyword = seoKeyword;
            SeoPageDescription = seoPageDescription;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoPageDescription { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}