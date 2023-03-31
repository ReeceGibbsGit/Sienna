using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sienna.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddingTimeStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "EspressoShots",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "EspressoShots");
        }
    }
}
