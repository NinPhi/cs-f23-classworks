using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L23_EFCore_Configuration.Data.Migrations
{
    /// <inheritdoc />
    public partial class Order_ChangeIdColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Identifier",
                table: "Orders",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "Identifier");
        }
    }
}
