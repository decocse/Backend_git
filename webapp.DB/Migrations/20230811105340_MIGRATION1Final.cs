using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.DB.Migrations
{
    /// <inheritdoc />
    public partial class MIGRATION1Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "ItemDB",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EmployeeMaster",
                newName: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemDB",
                newName: "ItemID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EmployeeMaster",
                newName: "Id");
        }
    }
}
