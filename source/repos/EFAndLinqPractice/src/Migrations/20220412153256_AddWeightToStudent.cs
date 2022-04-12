using Microsoft.EntityFrameworkCore.Migrations;

namespace EFAndLinqPractice_SchoolAPI.Migrations
{
    public partial class AddWeightToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Students",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Students");
        }
    }
}
