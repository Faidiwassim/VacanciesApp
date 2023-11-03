using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmplyeeId",
                table: "Employee",
                newName: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employee",
                newName: "EmplyeeId");
        }
    }
}
