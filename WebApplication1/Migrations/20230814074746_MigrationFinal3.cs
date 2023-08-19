using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class MigrationFinal3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeCardDetails",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "Guid", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanId = table.Column<string>(type: "Guid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCardDetails", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "employeeIssueDetails",
                columns: table => new
                {
                    IssueId = table.Column<int>(type: "Guid", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "Guid", nullable: false),
                    LoanId = table.Column<int>(type: "Guid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeIssueDetails", x => x.IssueId);
                });

            migrationBuilder.CreateTable(
                name: "LoanCardMaster",
                columns: table => new
                {
                    LoanId = table.Column<int>(type: "guid", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanType = table.Column<string>(type: "varchar(15)", nullable: false),
                    Duration = table.Column<int>(type: "int(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanCardMaster", x => x.LoanId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCardDetails");

            migrationBuilder.DropTable(
                name: "employeeIssueDetails");

            migrationBuilder.DropTable(
                name: "LoanCardMaster");
        }
    }
}
