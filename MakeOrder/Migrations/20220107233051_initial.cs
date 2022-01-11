using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeOrder.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    FoodId = table.Column<string>(nullable: false),
                    Qte = table.Column<int>(nullable: false),
                    ClientId = table.Column<string>(nullable: true),
                    ClientAdresse = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.FoodId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
