using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSafelyDeleteColumnExample.Migrations
{
    public partial class RemoveColumnFromQueries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* We do not remove the column here because of rollback compability */

            //migrationBuilder.DropColumn(
            //    name: "PropToBeDeleted",
            //    table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "PropToBeDeleted",
            //    table: "Persons",
            //    type: "nvarchar(max)",
            //    nullable: true);
        }
    }
}
