using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentImagecolumnonStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentImg",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentImg",
                table: "Students");
        }
    }
}
