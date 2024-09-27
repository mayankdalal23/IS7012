using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatDalalmk.Migrations
{
    /// <inheritdoc />
    public partial class console : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Resume",
                table: "Candidate",
                newName: "Skills");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Candidate",
                newName: "Resume");
        }
    }
}
