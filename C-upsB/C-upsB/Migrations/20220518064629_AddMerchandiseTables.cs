using Microsoft.EntityFrameworkCore.Migrations;

namespace C_upsB.Migrations
{
    public partial class AddMerchandiseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchandises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<double>(type: "float", nullable: false),
                    Information = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MerchandiseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandiseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchandiseTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MerchandiseTypes_Merchandises_MerchandiseId",
                        column: x => x.MerchandiseId,
                        principalTable: "Merchandises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MerchandiseTypes_MerchandiseId",
                table: "MerchandiseTypes",
                column: "MerchandiseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MerchandiseTypes");

            migrationBuilder.DropTable(
                name: "Merchandises");
        }
    }
}
