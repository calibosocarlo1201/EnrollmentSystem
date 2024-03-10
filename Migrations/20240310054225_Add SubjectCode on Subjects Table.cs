using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddSubjectCodeonSubjectsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubjectCode",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectCode",
                table: "Subjects");
        }
    }
}
