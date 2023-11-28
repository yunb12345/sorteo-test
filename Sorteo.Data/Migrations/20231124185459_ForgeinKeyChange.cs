using Microsoft.EntityFrameworkCore.Migrations;

namespace Sorteo.Data.Migrations
{
    public partial class ForgeinKeyChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SorteoParticipantes_DetalleSorteoId",
                table: "SorteoParticipantes",
                column: "DetalleSorteoId");

            migrationBuilder.CreateIndex(
                name: "IX_SorteoParticipantes_SorteoId",
                table: "SorteoParticipantes",
                column: "SorteoId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_DireccionId",
                table: "Participantes",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_PaisId",
                table: "Direcciones",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_ProvinciaId",
                table: "Direcciones",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Paises_PaisId",
                table: "Direcciones",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Provincias_ProvinciaId",
                table: "Direcciones",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Direcciones_DireccionId",
                table: "Participantes",
                column: "DireccionId",
                principalTable: "Direcciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SorteoParticipantes_DetaalleSorteos_DetalleSorteoId",
                table: "SorteoParticipantes",
                column: "DetalleSorteoId",
                principalTable: "DetaalleSorteos",
                principalColumn: "DetalleSorteoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SorteoParticipantes_Sorteos_SorteoId",
                table: "SorteoParticipantes",
                column: "SorteoId",
                principalTable: "Sorteos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Paises_PaisId",
                table: "Direcciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Provincias_ProvinciaId",
                table: "Direcciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Direcciones_DireccionId",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_SorteoParticipantes_DetaalleSorteos_DetalleSorteoId",
                table: "SorteoParticipantes");

            migrationBuilder.DropForeignKey(
                name: "FK_SorteoParticipantes_Sorteos_SorteoId",
                table: "SorteoParticipantes");

            migrationBuilder.DropIndex(
                name: "IX_SorteoParticipantes_DetalleSorteoId",
                table: "SorteoParticipantes");

            migrationBuilder.DropIndex(
                name: "IX_SorteoParticipantes_SorteoId",
                table: "SorteoParticipantes");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_DireccionId",
                table: "Participantes");

            migrationBuilder.DropIndex(
                name: "IX_Direcciones_PaisId",
                table: "Direcciones");

            migrationBuilder.DropIndex(
                name: "IX_Direcciones_ProvinciaId",
                table: "Direcciones");
        }
    }
}
