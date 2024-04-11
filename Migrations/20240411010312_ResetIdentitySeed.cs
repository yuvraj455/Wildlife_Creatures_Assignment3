using Microsoft.EntityFrameworkCore.Migrations;

namespace WildlifeCreatures_Assignment3.Migrations
{
    public partial class ResetIdentitySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DBCC CHECKIDENT ('WildlifeModel', RESEED, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // No need to implement Down method for this migration
        }
    }
}
