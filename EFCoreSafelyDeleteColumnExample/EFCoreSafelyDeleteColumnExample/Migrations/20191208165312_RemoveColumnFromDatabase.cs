using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSafelyDeleteColumnExample.Migrations
{
    public partial class RemoveColumnFromDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* Now we remove this column. This would be done some time after the previous migration has been running in prod for a while.
             * We can rollback to the previous version of the code and run on this DB schema version. But we could not run the "Initial"
             * version of the code on this schema
             */

            migrationBuilder.DropColumn(
                name: "PropToBeDeleted",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PropToBeDeleted",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
