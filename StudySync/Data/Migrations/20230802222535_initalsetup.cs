using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudySync.Data.Migrations
{
    public partial class initalsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndexCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndexCard");
        }
    }
}
