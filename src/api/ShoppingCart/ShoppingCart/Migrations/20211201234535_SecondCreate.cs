using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShippingPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingPrices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ShippingPrices",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[] { 1, 25.99m, "Overnight" });

            migrationBuilder.InsertData(
                table: "ShippingPrices",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[] { 2, 9.99m, "2-Day" });

            migrationBuilder.InsertData(
                table: "ShippingPrices",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[] { 3, 2.99m, "Postal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShippingPrices");
        }
    }
}
