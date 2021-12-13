using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.Migrations
{
    public partial class quizzes1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Quizes");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Quizes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Quizes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Quizes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
