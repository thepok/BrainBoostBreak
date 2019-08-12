using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainBoostBreak.Server.Migrations
{
    public partial class AddTopicToAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 1,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 2,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 3,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 4,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 5,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 6,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 7,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 8,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 9,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 10,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 11,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 12,
                column: "TopicId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 13,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 14,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 15,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 16,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 17,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 18,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 19,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 20,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 21,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 22,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 23,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 24,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 25,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 26,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 27,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 28,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 29,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 30,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 31,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 32,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 33,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 34,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 35,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 36,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 37,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 38,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 39,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 40,
                column: "TopicId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 41,
                column: "TopicId",
                value: -2);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TopicId",
                table: "Answers",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Topics_TopicId",
                table: "Answers",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Topics_TopicId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_TopicId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Answers");
        }
    }
}
