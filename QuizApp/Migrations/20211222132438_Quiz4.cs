using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.Migrations
{
    public partial class Quiz4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_quiz_QuizId",
                table: "Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Score",
                table: "Score");

            migrationBuilder.RenameTable(
                name: "Score",
                newName: "score");

            migrationBuilder.RenameIndex(
                name: "IX_Score_QuizId",
                table: "score",
                newName: "IX_score_QuizId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_score",
                table: "score",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_score_quiz_QuizId",
                table: "score",
                column: "QuizId",
                principalTable: "quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_score_quiz_QuizId",
                table: "score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_score",
                table: "score");

            migrationBuilder.RenameTable(
                name: "score",
                newName: "Score");

            migrationBuilder.RenameIndex(
                name: "IX_score_QuizId",
                table: "Score",
                newName: "IX_Score_QuizId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Score",
                table: "Score",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_quiz_QuizId",
                table: "Score",
                column: "QuizId",
                principalTable: "quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
