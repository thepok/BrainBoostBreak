using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrainBoostBreak.Server.Migrations
{
    public partial class Math : Migration
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
                    VoiceText = table.Column<string>(nullable: true),
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
                    { -2, "Buchstaben lernen" },
                    { -3, "Mama und Papa" },
                    { -4, "Mama und Papa ohne Hilfe" },
                    { -5, "Einfache Mathe" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerDescription", "Text", "TopicId", "Url" },
                values: new object[,]
                {
                    { 1, null, "Sokrates", -1, null },
                    { 71, null, "Mami", -3, null },
                    { 70, null, "Papi", -3, null },
                    { 69, null, "mi", -3, null },
                    { 68, null, "pi", -3, null },
                    { 67, null, "i", -3, null },
                    { 66, null, "Papa", -3, null },
                    { 65, null, "Pa", -3, null },
                    { 64, null, "P", -3, null },
                    { 63, null, "Mama", -3, null },
                    { 72, null, "Mam", -3, null },
                    { 62, null, "Ma", -3, null },
                    { 60, null, "M", -3, null },
                    { 59, null, "ö", -2, null },
                    { 58, null, "ü", -2, null },
                    { 57, null, "ä", -2, null },
                    { 56, null, "z", -2, null },
                    { 55, null, "y", -2, null },
                    { 54, null, "x", -2, null },
                    { 53, null, "w", -2, null },
                    { 52, null, "v", -2, null },
                    { 61, null, "a", -3, null },
                    { 73, null, "M", -4, null },
                    { 74, null, "a", -4, null },
                    { 75, null, "Ma", -4, null },
                    { 96, null, "5", -5, null },
                    { 95, null, "5", -5, null },
                    { 94, null, "4", -5, null },
                    { 93, null, "4", -5, null },
                    { 92, null, "4", -5, null },
                    { 91, null, "3", -5, null },
                    { 90, null, "5", -5, null },
                    { 89, null, "5", -5, null },
                    { 88, null, "4", -5, null },
                    { 87, null, "3", -5, null },
                    { 86, null, "2", -5, null },
                    { 85, null, "Mam", -4, null },
                    { 84, null, "Mami", -4, null },
                    { 83, null, "Papi", -4, null },
                    { 82, null, "mi", -4, null },
                    { 81, null, "pi", -4, null },
                    { 80, null, "i", -4, null },
                    { 79, null, "Papa", -4, null },
                    { 78, null, "Pa", -4, null },
                    { 77, null, "P", -4, null },
                    { 76, null, "Mama", -4, null },
                    { 51, null, "u", -2, null },
                    { 50, null, "t", -2, null },
                    { 49, null, "s", -2, null },
                    { 48, null, "r", -2, null },
                    { 22, null, "Platon", -1, null },
                    { 21, null, "Sokrates", -1, null },
                    { 20, null, "Fidel Castro", -1, null },
                    { 19, null, "Siddhartha Gautama", -1, null },
                    { 18, null, "Paracelsus", -1, null },
                    { 17, null, "Friedrich Nietzsche", -1, null },
                    { 16, null, "Platon", -1, null },
                    { 15, null, "Sokrates", -1, null },
                    { 14, null, "Fidel Castro", -1, null },
                    { 13, null, "Jean-Jacques Rousseau", -1, null },
                    { 12, null, "Paracelsus", -1, null },
                    { 11, null, "Friedrich Nietzsche", -1, null },
                    { 10, null, "Platon", -1, null },
                    { 9, null, "Sokrates", -1, null },
                    { 8, null, "Fidel Castro", -1, null },
                    { 7, null, "Mahatma Gandhi", -1, null },
                    { 6, null, "Baruch de Spinoza", -1, null },
                    { 5, null, "Erasmus von Rotterdam", -1, null },
                    { 4, null, "Paracelsus", -1, null },
                    { 3, null, "Friedrich Nietzsche", -1, null },
                    { 2, null, "Platon", -1, null },
                    { 23, null, "Friedrich Nietzsche", -1, null },
                    { 97, null, "5", -5, null },
                    { 24, null, "Paracelsus", -1, null },
                    { 26, null, "Fidel Castro", -1, null },
                    { 47, null, "q", -2, null },
                    { 46, null, "p", -2, null },
                    { 45, null, "o", -2, null },
                    { 44, null, "n", -2, null },
                    { 43, null, "m", -2, null },
                    { 42, null, "l", -2, null },
                    { 41, null, "k", -2, null },
                    { 40, null, "j", -2, null },
                    { 39, null, "i", -2, null },
                    { 38, null, "h", -2, null },
                    { 37, null, "g", -2, null },
                    { 36, null, "f", -2, null },
                    { 35, null, "e", -2, null },
                    { 34, null, "d", -2, null },
                    { 33, null, "c", -2, null },
                    { 32, null, "b", -2, null },
                    { 31, null, "a", -2, null },
                    { 30, null, "Paracelsus", -1, null },
                    { 29, null, "Friedrich Nietzsche", -1, null },
                    { 28, null, "Platon", -1, null },
                    { 27, null, "Sokrates", -1, null },
                    { 25, null, "Theodor Fontane", -1, null },
                    { 98, null, "6", -5, null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "AnswerId", "Text", "TopicId", "VoiceText" },
                values: new object[,]
                {
                    { 1, 1, "Wem wird folgendes Zitat zugeschrieben: 'Wer glaubt, etwas zu sein, hat aufgehört, etwas zu werden.'", -1, "Wem wird folgendes Zitat zugeschrieben: 'Wer glaubt, etwas zu sein, hat aufgehört, etwas zu werden.'" },
                    { 52, 77, "", -4, "P" },
                    { 51, 76, "", -4, "Mama" },
                    { 50, 75, "", -4, "Ma" },
                    { 49, 74, "", -4, "a" },
                    { 48, 73, "", -4, "M" },
                    { 47, 72, "Mam", -3, "Mam" },
                    { 53, 78, "", -4, "Pa" },
                    { 46, 71, "Mami", -3, "Mami" },
                    { 44, 69, "mi", -3, "mi" },
                    { 43, 68, "pi", -3, "pi" },
                    { 42, 67, "i", -3, "i" },
                    { 41, 66, "Papa", -3, "Papa" },
                    { 40, 65, "Pa", -3, "Pa" },
                    { 39, 64, "P", -3, "P" },
                    { 45, 70, "Papi", -3, "Papi" },
                    { 54, 79, "", -4, "Papa" },
                    { 55, 80, "", -4, "i" },
                    { 56, 81, "", -4, "pi" },
                    { 71, 96, "1 + 2 + 2", -5, "1 + 2 + 2" },
                    { 70, 95, "2 + 2 + 1", -5, "2 + 2 + 1" },
                    { 69, 94, "1 + 1 + 2", -5, "1 + 1 + 2" },
                    { 68, 93, "1 + 2 + 1", -5, "1 + 2 + 1" },
                    { 67, 92, "2 + 1 + 1", -5, "2 + 1 + 1" },
                    { 66, 91, "1 + 1 + 1", -5, "1 + 1 + 1" },
                    { 65, 90, "3 + 2", -5, "3 + 2" },
                    { 64, 89, "2 + 3", -5, "2 + 3" },
                    { 63, 88, "2 + 1", -5, "2 + 1" },
                    { 62, 87, "1 + 2", -5, "1 + 2" },
                    { 61, 86, "1 + 1", -5, "1 + 1" },
                    { 60, 85, "", -4, "Mam" },
                    { 59, 84, "", -4, "Mami" },
                    { 58, 83, "", -4, "Papi" },
                    { 57, 82, "", -4, "mi" },
                    { 38, 63, "Mama", -3, "Mama" },
                    { 72, 97, "2 + 1 + 2", -5, "2 + 1 + 2" },
                    { 37, 62, "Ma", -3, "Ma" },
                    { 35, 60, "M", -3, "M" },
                    { 15, 40, "J", -2, "J" },
                    { 14, 39, "I", -2, "I" },
                    { 13, 38, "H", -2, "H" },
                    { 12, 37, "G", -2, "G" },
                    { 11, 36, "F", -2, "F" },
                    { 10, 35, "E", -2, "E" },
                    { 16, 41, "K", -2, "K" },
                    { 9, 34, "D", -2, "D" },
                    { 7, 32, "B", -2, "B" },
                    { 6, 31, "A", -2, "A" },
                    { 5, 25, "Wem wird folgendes Zitat zugeschrieben: 'Gegen eine Dummheit, die gerade in Mode ist, kommt keine Klugheit auf.'", -1, "Wem wird folgendes Zitat zugeschrieben: 'Gegen eine Dummheit, die gerade in Mode ist, kommt keine Klugheit auf.'" },
                    { 4, 19, "Wem wird folgendes Zitat zugeschrieben: 'Wir sind, was wir denken. Alles, was wir sind, entsteht aus unseren Gedanken. Mit unseren Gedanken formen wir die Welt.'", -1, "Wem wird folgendes Zitat zugeschrieben: 'Wir sind, was wir denken. Alles, was wir sind, entsteht aus unseren Gedanken. Mit unseren Gedanken formen wir die Welt.'" },
                    { 3, 13, "Wem wird folgendes Zitat zugeschrieben: 'Das Geld, das man besitzt, ist das Mittel zur Freiheit, dasjenige, dem man nachjagt, das Mittel zur Knechtschaft.'", -1, "Wem wird folgendes Zitat zugeschrieben: 'Das Geld, das man besitzt, ist das Mittel zur Freiheit, dasjenige, dem man nachjagt, das Mittel zur Knechtschaft.'" },
                    { 2, 7, "Wem wird folgendes Zitat zugeschrieben: 'Gewalt ist die Waffe des Schwachen.'", -1, "Wem wird folgendes Zitat zugeschrieben: 'Gewalt ist die Waffe des Schwachen.'" },
                    { 8, 33, "C", -2, "C" },
                    { 17, 42, "L", -2, "L" },
                    { 18, 43, "M", -2, "M" },
                    { 19, 44, "N", -2, "N" },
                    { 34, 59, "Ö", -2, "Ö" },
                    { 33, 58, "Ü", -2, "Ü" },
                    { 32, 57, "Ä", -2, "Ä" },
                    { 31, 56, "Z", -2, "Z" },
                    { 30, 55, "Y", -2, "Y" },
                    { 29, 54, "X", -2, "X" },
                    { 28, 53, "W", -2, "W" },
                    { 27, 52, "V", -2, "V" },
                    { 26, 51, "U", -2, "U" },
                    { 25, 50, "T", -2, "T" },
                    { 24, 49, "S", -2, "S" },
                    { 23, 48, "R", -2, "R" },
                    { 22, 47, "Q", -2, "Q" },
                    { 21, 46, "P", -2, "P" },
                    { 20, 45, "O", -2, "O" },
                    { 36, 61, "a", -3, "a" },
                    { 73, 98, "2 + 2 + 2", -5, "2 + 2 + 2" }
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
