using Microsoft.EntityFrameworkCore.Migrations;

namespace C_upsB.Migrations
{
    public partial class AddBlogTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogRelateds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogRelateds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntroContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogDetailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoCoffe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleSecond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleThird = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentHeaderTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleFourth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleFifth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentHeaderThird = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleSix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleSeven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleEight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogRelateds");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
