using Microsoft.EntityFrameworkCore.Migrations;

namespace C_upsB.Migrations
{
    public partial class AddAboutUsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntroContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FounderImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FounderStory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutMainImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutLittleImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTextFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTextSecond = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutTexts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutDetails");

            migrationBuilder.DropTable(
                name: "AboutImages");

            migrationBuilder.DropTable(
                name: "AboutTexts");
        }
    }
}
