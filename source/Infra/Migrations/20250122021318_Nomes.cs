using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Nomes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_TipoMovimentacaoId",
                table: "CategoriaMovis");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuarios",
                newName: "Picture");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Usuarios",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "Usuarios",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Logins",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "TipoMovimentacaoId",
                table: "CategoriaMovis",
                newName: "TypeMovementId");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "CategoriaMovis",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaMovis_TipoMovimentacaoId",
                table: "CategoriaMovis",
                newName: "IX_CategoriaMovis_TypeMovementId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_TypeMovementId",
                table: "CategoriaMovis",
                column: "TypeMovementId",
                principalTable: "TipoMovimentacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_TypeMovementId",
                table: "CategoriaMovis");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Usuarios",
                newName: "Cargo");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Usuarios",
                newName: "Foto");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Logins",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "TypeMovementId",
                table: "CategoriaMovis",
                newName: "TipoMovimentacaoId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CategoriaMovis",
                newName: "Descricao");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaMovis_TypeMovementId",
                table: "CategoriaMovis",
                newName: "IX_CategoriaMovis_TipoMovimentacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_TipoMovimentacaoId",
                table: "CategoriaMovis",
                column: "TipoMovimentacaoId",
                principalTable: "TipoMovimentacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
