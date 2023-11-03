using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "xxxn",
                table: "Employee",
                newName: "JobPosition");

            migrationBuilder.RenameColumn(
                name: "dvvv",
                table: "Employee",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "VacancyDays",
                table: "Employee",
                newName: "TotalVacancyDays");

            migrationBuilder.AddColumn<int>(
                name: "RestVacancyDays",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestVacancyDays",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employee",
                newName: "dvvv");

            migrationBuilder.RenameColumn(
                name: "JobPosition",
                table: "Employee",
                newName: "xxxn");

            migrationBuilder.RenameColumn(
                name: "TotalVacancyDays",
                table: "Employee",
                newName: "VacancyDays");
        }
    }
}
