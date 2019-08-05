using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrainBoostBreak.Server.Migrations
{
    public partial class FixQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Questions",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnswerId",
                table: "Questions",
                column: "AnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Answers_AnswerId",
                table: "Questions",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "AnswerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Answers_AnswerId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_AnswerId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Questions",
                nullable: false,
                defaultValue: "")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);
        }
    }
}
