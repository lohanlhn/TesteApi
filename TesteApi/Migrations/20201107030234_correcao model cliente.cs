using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteApi.Migrations
{
    public partial class correcaomodelcliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mensagem_ClienteId",
                table: "Mensagem");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_ClienteId",
                table: "Mensagem",
                column: "ClienteId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mensagem_ClienteId",
                table: "Mensagem");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagem_ClienteId",
                table: "Mensagem",
                column: "ClienteId");
        }
    }
}
