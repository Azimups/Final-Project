using Microsoft.EntityFrameworkCore.Migrations;

namespace C_upsB.Migrations
{
    public partial class AddLocationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAddressPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAddressCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondHeadline = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
