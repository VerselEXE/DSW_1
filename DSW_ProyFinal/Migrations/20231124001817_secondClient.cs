using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSW_ProyFinal.Migrations
{
    public partial class secondClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    idClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneClient = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.idClient);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
