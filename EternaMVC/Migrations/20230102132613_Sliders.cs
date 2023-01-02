using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaMVC.Migrations
{
    public partial class Sliders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Sliders",
                newName: "SecondHeader");

            migrationBuilder.AddColumn<string>(
                name: "FirstHeader",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstHeader",
                table: "Sliders");

            migrationBuilder.RenameColumn(
                name: "SecondHeader",
                table: "Sliders",
                newName: "Header");
        }
    }
}
