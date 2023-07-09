using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class AddStoredProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "PersonPerson",
                newName: "PersonPerson",
                newSchema: "dbo");

            // Stored Procedure GetPersonsByState
            var proc1 = @"
                        IF OBJECT_ID('GetPersonsByState', 'P') IS NOT NULL
                        DROP PROC UpdateProfilesCountry
                        GO

                        CREATE PROCEDURE [dbo].[GetPersonsByState]
                            @state varchar(255)
                        AS
                        BEGIN
                            SELECT p.* 
                            FROM Person p 
                            INNER JOIN Address a on p.Id = a.PersonId 
                            WHERE State = @state
                        END";

            // stored procedure AddLookupItem
            var proc2 = @"
                        IF OBJECT_ID('AddLookUpItem', 'P') IS NOT NULL
                        DROP PROC AddLookupItem
                        GO

                        CREATE PROCEDURE [dbo].[AddLookUpItem]
                            @Code varchar(255),
                            @Description varchar(255),
                            @LookUpTypeId int
                        AS
                        BEGIN
                            INSERT INTO LookUp (Code, Description, LookUpType) VALUES (@Code, @Description, @LookUpTypeId)
                        END";

            migrationBuilder.Sql(proc1);
            migrationBuilder.Sql(proc2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "PersonPerson",
                schema: "dbo",
                newName: "PersonPerson");

            migrationBuilder.Sql(@"DROP PROC GetPersonsByState");

            migrationBuilder.Sql(@"DROP PROC AddLookUpItem");
        }
    }
}
