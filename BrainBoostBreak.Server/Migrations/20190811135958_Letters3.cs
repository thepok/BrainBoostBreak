using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainBoostBreak.Server.Migrations
{
    public partial class Letters3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "AnswerId", "Text", "TopicId" },
                values: new object[,]
                {
                    { 1, 1, "Wem wird folgendes Zitat zugeschrieben: 'Wer glaubt, etwas zu sein, hat aufgehört, etwas zu werden.'", -1 },
                    { 29, 39, "Ä", -2 },
                    { 28, 38, "Z", -2 },
                    { 27, 37, "Y", -2 },
                    { 26, 36, "X", -2 },
                    { 25, 35, "W", -2 },
                    { 24, 34, "V", -2 },
                    { 23, 33, "U", -2 },
                    { 22, 32, "T", -2 },
                    { 21, 31, "S", -2 },
                    { 20, 30, "R", -2 },
                    { 19, 29, "Q", -2 },
                    { 18, 28, "P", -2 },
                    { 17, 27, "O", -2 },
                    { 30, 40, "Ü", -2 },
                    { 16, 26, "N", -2 },
                    { 14, 24, "L", -2 },
                    { 13, 23, "K", -2 },
                    { 12, 22, "J", -2 },
                    { 11, 21, "I", -2 },
                    { 10, 20, "H", -2 },
                    { 9, 19, "G", -2 },
                    { 8, 18, "F", -2 },
                    { 7, 17, "E", -2 },
                    { 6, 16, "D", -2 },
                    { 5, 15, "C", -2 },
                    { 4, 14, "B", -2 },
                    { 3, 13, "A", -2 },
                    { 2, 7, "Wem wird folgendes Zitat zugeschrieben: 'Gewalt ist die Waffe des Schwachen.'", -1 },
                    { 15, 25, "M", -2 },
                    { 31, 41, "Ö", -2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 31);
        }
    }
}
