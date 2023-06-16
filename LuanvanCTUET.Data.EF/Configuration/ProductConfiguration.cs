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
            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Image);
            builder.Property(p => p.Price).HasColumnType("decimal(10,0)");
            builder.Property(p => p.PromotionPrice).HasColumnType("decimal(10,0)");
            builder.Property(p => p.OriginalPrice).HasColumnType("decimal(10,0)").IsRequired();
            builder.Property(p => p.Description);
            builder.Property(p => p.Content);
            builder.Property(p => p.Unit);
            builder.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId);
        }
    }
}
