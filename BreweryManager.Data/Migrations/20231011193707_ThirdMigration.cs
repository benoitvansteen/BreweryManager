using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreweryManager.Data.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WolesalerId",
                table: "wholesalerBeerProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WolesalerId",
                table: "wholesalerBeerProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
