using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListingAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreCorto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hoteles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reseña = table.Column<double>(type: "float", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoteles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoteles_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre", "NombreCorto" },
                values: new object[,]
                {
                    { 1, "Jamaica", "JM" },
                    { 2, "Bahamas", "BS" },
                    { 3, "Chile", "CL" },
                    { 4, "Venezuela", "VE" }
                });

            migrationBuilder.InsertData(
                table: "Hoteles",
                columns: new[] { "Id", "Direccion", "Nombre", "PaisId", "Reseña" },
                values: new object[,]
                {
                    { 1, "Negril", "Sandals Resort an Spa", 1, 4.5 },
                    { 2, "George Town", "Comfort Suites", 2, 4.2999999999999998 },
                    { 3, "Av Vitacura 130", "AC Hotel", 3, 4.2000000000000002 },
                    { 4, "Cerro el Avila", "Hotel Humbolt", 4, 4.7000000000000002 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hoteles_PaisId",
                table: "Hoteles",
                column: "PaisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hoteles");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
