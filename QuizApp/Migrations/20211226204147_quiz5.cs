using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace QuizApp.Migrations
{
    public partial class quiz5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answer_question_QuestionId",
                table: "answer");

            migrationBuilder.DropForeignKey(
                name: "FK_question_quiz_QuizId",
                table: "question");

            migrationBuilder.DropForeignKey(
                name: "FK_score_quiz_QuizId",
                table: "score");

            migrationBuilder.AlterColumn<Guid>(
                name: "QuizId",
                table: "score",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "QuizId",
                table: "question",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "QuestionId",
                table: "answer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_answer_question_QuestionId",
                table: "answer",
                column: "QuestionId",
                principalTable: "question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_question_quiz_QuizId",
                table: "question",
                column: "QuizId",
                principalTable: "quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_score_quiz_QuizId",
                table: "score",
                column: "QuizId",
                principalTable: "quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answer_question_QuestionId",
                table: "answer");

            migrationBuilder.DropForeignKey(
                name: "FK_question_quiz_QuizId",
                table: "question");

            migrationBuilder.DropForeignKey(
                name: "FK_score_quiz_QuizId",
                table: "score");

            migrationBuilder.AlterColumn<Guid>(
                name: "QuizId",
                table: "score",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "QuizId",
                table: "question",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "QuestionId",
                table: "answer",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_answer_question_QuestionId",
                table: "answer",
                column: "QuestionId",
                principalTable: "question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_question_quiz_QuizId",
                table: "question",
                column: "QuizId",
                principalTable: "quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_score_quiz_QuizId",
                table: "score",
                column: "QuizId",
                principalTable: "quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
