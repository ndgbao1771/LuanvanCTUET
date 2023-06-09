using LuanvanCTUET.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanvanCTUET.Data.EF.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).HasMaxLength(255).IsRequired().HasColumnName("Tên sản phẩm");
            builder.Property(p => p.Image).HasColumnName("Hình ảnh");
            builder.Property(p => p.Price).HasColumnType("decimal(10,0)").HasColumnName("Giá sản phẩm");
            builder.Property(p => p.PromotionPrice).HasColumnType("decimal(10,0)").HasColumnName("Giá khuyến mãi");
            builder.Property(p => p.OriginalPrice).HasColumnType("decimal(10,0)").IsRequired().HasColumnName("Giá gốc");
            builder.Property(p => p.Description).HasColumnName("Thông tin chi tiết");
            builder.Property(p => p.Content).HasColumnName("Mô tả sản phẩm");
            builder.Property(p => p.Unit).HasColumnName("Đơn vị tính");
            builder.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId);
        }
    }
}
