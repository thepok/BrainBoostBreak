using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrainBoostBreak.Server.Migrations
{
    public partial class NewInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Text = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    AnswerDescription = table.Column<string>(nullable: true),
                    TopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TopicId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    AnswerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "AnswerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "Name" },
                values: new object[,]
                {
                    { -1, "Zitate" },
                    { -2, "Buchstaben lernen" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerDescription", "Text", "TopicId", "Url" },
                values: new object[,]
                {
                    { 1, null, "Sokrates", -1, null },
                    { 23, null, "k", -2, null },
                    { 24, null, "l", -2, null },
                    { 25, null, "m", -2, null },
                    { 26, null, "n", -2, null },
                    { 27, null, "o", -2, null },
                    { 28, null, "p", -2, null },
                    { 29, null, "q", -2, null },
                    { 30, null, "r", -2, null },
                    { 31, null, "s", -2, null },
                    { 32, null, "t", -2, null },
                    { 33, null, "u", -2, null },
                    { 34, null, "v", -2, null },
                    { 35, null, "w", -2, null },
                    { 36, null, "x", -2, null },
                    { 37, null, "y", -2, null },
                    { 38, null, "z", -2, null },
                    { 39, null, "ä", -2, null },
                    { 22, null, "j", -2, null },
                    { 40, null, "ü", -2, null },
                    { 21, null, "i", -2, null },
                    { 19, null, "g", -2, null },
                    { 2, null, "Platon", -1, null },
                    { 3, null, "Friedrich Nietzsche", -1, null },
                    { 4, null, "Paracelsus", -1, null },
                    { 5, null, "Erasmus von Rotterdam", -1, null },
                    { 6, null, "Baruch de Spinoza", -1, null },
                    { 7, null, "Mahatma Gandhi", -1, null },
                    { 8, null, "Fidel Castro", -1, null },
                    { 9, null, "Sokrates", -1, null },
                    { 10, null, "Platon", -1, null },
                    { 11, null, "Friedrich Nietzsche", -1, null },
                    { 12, null, "Paracelsus", -1, null },
                    { 13, null, "a", -2, null },
                    { 14, null, "b", -2, null },
                    { 15, null, "c", -2, null },
                    { 16, null, "d", -2, null },
                    { 17, null, "e", -2, null },
                    { 18, null, "f", -2, null },
                    { 20, null, "h", -2, null },
                    { 41, null, "ö", -2, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TopicId",
                table: "Answers",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnswerId",
                table: "Questions",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
