using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class MigrationFinal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeMaster",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "Guid", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "varchar(20)", nullable: false),
                    Designation = table.Column<string>(type: "varchar(25)", nullable: false),
                    Department = table.Column<string>(type: "varchar(25)", nullable: false),
                    Gender = table.Column<string>(type: "char(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMaster", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "ItemDB",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "Guid", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemDescription = table.Column<string>(type: "varchar(25)", nullable: false),
                    IssueStatus = table.Column<string>(type: "char(1)", nullable: false),
                    ItemMake = table.Column<string>(type: "varchar(25)", nullable: false),
                    ItemCategory = table.Column<string>(type: "varchar(20)", nullable: false),
                    ItemValue = table.Column<int>(type: "int(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDB", x => x.ItemId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeMaster");

            migrationBuilder.DropTable(
                name: "ItemDB");
        }
    }
}
