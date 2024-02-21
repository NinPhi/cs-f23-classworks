using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L22_Migrations.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameMovieTitleToName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "Title");
        }
    }
}
