using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class AddStateAL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "LookUp",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[] { "AL", "Alabama", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LookUp",
                keyColumn: "Code",
                keyValue: "AL");
        }
    }
}
