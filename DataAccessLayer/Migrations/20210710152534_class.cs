using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class @class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Class",
                table: "Istatistics",
                newName: "ProjectClass");

            migrationBuilder.AddColumn<string>(
                name: "CompletedClass",
                table: "Istatistics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomersClass",
                table: "Istatistics",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedClass",
                table: "Istatistics");

            migrationBuilder.DropColumn(
                name: "CustomersClass",
                table: "Istatistics");

            migrationBuilder.RenameColumn(
                name: "ProjectClass",
                table: "Istatistics",
                newName: "Class");
        }
    }
}
