using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sienna.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddingBeanType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BeanType",
                table: "EspressoShots",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeanType",
                table: "EspressoShots");
        }
    }
}
