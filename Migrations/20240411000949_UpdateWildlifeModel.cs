using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WildlifeCreatures_Assignment3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWildlifeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentPopulation",
                table: "WildlifeModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Habitat",
                table: "WildlifeModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WildlifeModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "WildlifeModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "WildlifeModel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPopulation",
                table: "WildlifeModel");

            migrationBuilder.DropColumn(
                name: "Habitat",
                table: "WildlifeModel");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "WildlifeModel");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "WildlifeModel");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "WildlifeModel");
        }
    }
}
