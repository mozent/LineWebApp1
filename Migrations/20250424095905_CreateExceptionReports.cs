using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LineWebApp1.Migrations
{
    /// <inheritdoc />
    public partial class CreateExceptionReports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExceptionReports",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(14)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Reply = table.Column<int>(type: "int", nullable: false),
                    Report = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionReports", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExceptionReports");
        }
    }
}
