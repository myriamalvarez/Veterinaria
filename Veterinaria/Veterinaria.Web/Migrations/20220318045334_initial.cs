using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.Web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "propietarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dni = table.Column<string>(maxLength: 30, nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(maxLength: 30, nullable: false),
                    direccion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propietarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "propietarios");
        }
    }
}
