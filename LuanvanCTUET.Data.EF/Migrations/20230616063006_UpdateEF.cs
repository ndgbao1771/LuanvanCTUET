using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuanvanCTUET.Data.EF.Migrations
{
    public partial class UpdateEF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Đơn vị tính",
                table: "Products",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "Tên sản phẩm",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Thông tin chi tiết",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Mô tả sản phẩm",
                table: "Products",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Hình ảnh",
                table: "Products",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Giá sản phẩm",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Giá khuyến mãi",
                table: "Products",
                newName: "PromotionPrice");

            migrationBuilder.RenameColumn(
                name: "Giá gốc",
                table: "Products",
                newName: "OriginalPrice");

            migrationBuilder.RenameColumn(
                name: "Tên danh mục",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Mô tả danh mục",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Hình ảnh",
                table: "Categories",
                newName: "Image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Products",
                newName: "Đơn vị tính");

            migrationBuilder.RenameColumn(
                name: "PromotionPrice",
                table: "Products",
                newName: "Giá khuyến mãi");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Giá sản phẩm");

            migrationBuilder.RenameColumn(
                name: "OriginalPrice",
                table: "Products",
                newName: "Giá gốc");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Tên sản phẩm");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "Hình ảnh");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Thông tin chi tiết");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Products",
                newName: "Mô tả sản phẩm");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Tên danh mục");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Categories",
                newName: "Hình ảnh");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "Mô tả danh mục");
        }
    }
}
