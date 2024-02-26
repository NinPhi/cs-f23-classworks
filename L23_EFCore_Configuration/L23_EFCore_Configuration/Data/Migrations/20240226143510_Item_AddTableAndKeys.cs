using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L23_EFCore_Configuration.Data.Migrations
{
    /// <inheritdoc />
    public partial class Item_AddTableAndKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PricePerItem",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Orders",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Name)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItemName",
                table: "Orders",
                column: "ItemName");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Items_ItemName",
                table: "Orders",
                column: "ItemName",
                principalTable: "Items",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Items_ItemName",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ItemName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Item",
                table: "Orders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerItem",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
