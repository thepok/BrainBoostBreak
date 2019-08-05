using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrainBoostBreak.Server.Migrations
{
    public partial class AddTopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            migrationBuilder.AlterColumn<string>(
                name: "Answer",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Questions",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Text = table.Column<string>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TopicId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Questions");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            migrationBuilder.AlterColumn<string>(
                name: "Answer",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);
        }
    }
}
