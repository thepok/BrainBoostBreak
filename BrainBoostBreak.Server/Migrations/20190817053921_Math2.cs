using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainBoostBreak.Server.Migrations
{
    public partial class Math2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 88,
                column: "Text",
                value: "3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 88,
                column: "Text",
                value: "4");
        }
    }
}
