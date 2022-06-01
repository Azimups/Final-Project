using Microsoft.EntityFrameworkCore.Migrations;

namespace C_upsB.Migrations
{
    public partial class AddCategoryAndDrinkTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BtnText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedDrinkFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedDrinkSecond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedDrinkThird = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuHeader = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<double>(type: "float", nullable: false),
                    TypeFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeSecond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeThird = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformationHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionalCalories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionalTotalFat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionalCholesterol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionalSodium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionalTotalCarbs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionalTotalFiber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionalTotalSugar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionalTotalProtein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeLCalories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeLTotalFat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeLCholesterol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeLSodium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeLTotalCarbs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeLTotalFiber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeLTotalSugar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeLTotalProtein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMCalories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMTotalFat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMCholesterol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMSodium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMTotalCarbs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMTotalFiber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMTotalSugar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeMTotalProtein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSCalories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSTotalFat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSCholesterol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSSodium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSTotalCarbs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSTotalFiber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSTotalSugar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSTotalProtein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drinks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_CategoryId",
                table: "Drinks",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
