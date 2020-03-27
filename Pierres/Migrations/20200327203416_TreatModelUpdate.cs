using Microsoft.EntityFrameworkCore.Migrations;

namespace Pierres.Migrations
{
    public partial class TreatModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlavorId",
                table: "Treats",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlavorId",
                table: "Treats");
        }
    }
}
