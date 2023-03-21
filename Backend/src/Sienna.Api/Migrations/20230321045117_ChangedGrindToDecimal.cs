using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sienna.Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangedGrindToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Grind",
                table: "EspressoShots",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Grind",
                table: "EspressoShots",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
