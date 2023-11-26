using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSW_ProyFinal.Migrations
{
    public partial class pksActualizados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idProd",
                table: "Products",
                newName: "prodId");

            migrationBuilder.RenameColumn(
                name: "idClient",
                table: "Clients",
                newName: "clientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "prodId",
                table: "Products",
                newName: "idProd");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Clients",
                newName: "idClient");
        }
    }
}
