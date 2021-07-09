using Microsoft.EntityFrameworkCore.Migrations;

namespace ChacourShop.ProductAPI.Migrations
{
    public partial class AddedQuantityToProductModelToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockLevel",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockLevel",
                table: "Products");
        }
    }
}
