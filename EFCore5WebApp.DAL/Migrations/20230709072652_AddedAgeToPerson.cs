using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class AddedAgeToPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "PersonPerson",
                newName: "PersonPerson",
                newSchema: "dbo");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                schema: "dbo",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                schema: "dbo",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "PersonPerson",
                schema: "dbo",
                newName: "PersonPerson");
        }
    }
}
