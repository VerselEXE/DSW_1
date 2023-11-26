using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSW_ProyFinal.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    idProd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precioProd = table.Column<double>(type: "float", nullable: false),
                    descProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    catProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlProd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.idProd);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
