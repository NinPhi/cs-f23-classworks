using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L22_Migrations.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserFirstLastNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            """
            ALTER TABLE Users
            ADD FullName NVARCHAR(200) NOT NULL;

            GO

            UPDATE Users
            SET FullName = FirstName + N' ' + LastName;

            ALTER TABLE Users
            DROP COLUMN FirstName, LastName;
            """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            """
            ALTER TABLE Users
            DROP COLUMN FullName
            """);
        }
    }
}
