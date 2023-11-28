using Microsoft.EntityFrameworkCore.Migrations;

namespace Sorteo.Data.Migrations
{
    public partial class DetalleSorteo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DetalleParticipanteID",
                table: "DetaalleSorteos",
                newName: "ParticipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_DetaalleSorteos_ParticipanteId",
                table: "DetaalleSorteos",
                column: "ParticipanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetaalleSorteos_Participantes_ParticipanteId",
                table: "DetaalleSorteos",
                column: "ParticipanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetaalleSorteos_Participantes_ParticipanteId",
                table: "DetaalleSorteos");

            migrationBuilder.DropIndex(
                name: "IX_DetaalleSorteos_ParticipanteId",
                table: "DetaalleSorteos");

            migrationBuilder.RenameColumn(
                name: "ParticipanteId",
                table: "DetaalleSorteos",
                newName: "DetalleParticipanteID");
        }
    }
}
