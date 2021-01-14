using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen_Final_Suciu_.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salon",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serviciu = table.Column<string>(nullable: true),
                    Pret = table.Column<decimal>(nullable: false),
                    Durata = table.Column<string>(nullable: true),
                    Hairstylist = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salon", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salon");
        }
    }
}
