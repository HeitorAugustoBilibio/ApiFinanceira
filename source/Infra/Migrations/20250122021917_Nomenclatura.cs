using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Nomenclatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_TypeMovementId",
                table: "CategoriaMovis");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_TipoMovimentacao_TipoMovimentacaoId",
                table: "Movimentacao");

            migrationBuilder.RenameColumn(
                name: "Saida",
                table: "TipoMovimentacao",
                newName: "Leave");

            migrationBuilder.RenameColumn(
                name: "Entrada",
                table: "TipoMovimentacao",
                newName: "Enter");

            migrationBuilder.RenameColumn(
                name: "ValorJuros",
                table: "Movimentacao",
                newName: "ValueInterest");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Movimentacao",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "TipoMovimentacaoId",
                table: "Movimentacao",
                newName: "MovementTypeId");

            migrationBuilder.RenameColumn(
                name: "QuantidadeParcela",
                table: "Movimentacao",
                newName: "ParcelQuantity");

            migrationBuilder.RenameColumn(
                name: "Pagamento",
                table: "Movimentacao",
                newName: "Payment");

            migrationBuilder.RenameColumn(
                name: "NumeroParcela",
                table: "Movimentacao",
                newName: "ParcelNumber");

            migrationBuilder.RenameColumn(
                name: "Lançamento",
                table: "Movimentacao",
                newName: "Launch");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentacao_TipoMovimentacaoId",
                table: "Movimentacao",
                newName: "IX_Movimentacao_MovementTypeId");

            migrationBuilder.RenameColumn(
                name: "TypeMovementId",
                table: "CategoriaMovis",
                newName: "MovementTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaMovis_TypeMovementId",
                table: "CategoriaMovis",
                newName: "IX_CategoriaMovis_MovementTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_MovementTypeId",
                table: "CategoriaMovis",
                column: "MovementTypeId",
                principalTable: "TipoMovimentacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_TipoMovimentacao_MovementTypeId",
                table: "Movimentacao",
                column: "MovementTypeId",
                principalTable: "TipoMovimentacao",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_MovementTypeId",
                table: "CategoriaMovis");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_TipoMovimentacao_MovementTypeId",
                table: "Movimentacao");

            migrationBuilder.RenameColumn(
                name: "Leave",
                table: "TipoMovimentacao",
                newName: "Saida");

            migrationBuilder.RenameColumn(
                name: "Enter",
                table: "TipoMovimentacao",
                newName: "Entrada");

            migrationBuilder.RenameColumn(
                name: "ValueInterest",
                table: "Movimentacao",
                newName: "ValorJuros");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Movimentacao",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "Payment",
                table: "Movimentacao",
                newName: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "ParcelQuantity",
                table: "Movimentacao",
                newName: "QuantidadeParcela");

            migrationBuilder.RenameColumn(
                name: "ParcelNumber",
                table: "Movimentacao",
                newName: "NumeroParcela");

            migrationBuilder.RenameColumn(
                name: "MovementTypeId",
                table: "Movimentacao",
                newName: "TipoMovimentacaoId");

            migrationBuilder.RenameColumn(
                name: "Launch",
                table: "Movimentacao",
                newName: "Lançamento");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentacao_MovementTypeId",
                table: "Movimentacao",
                newName: "IX_Movimentacao_TipoMovimentacaoId");

            migrationBuilder.RenameColumn(
                name: "MovementTypeId",
                table: "CategoriaMovis",
                newName: "TypeMovementId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaMovis_MovementTypeId",
                table: "CategoriaMovis",
                newName: "IX_CategoriaMovis_TypeMovementId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_TypeMovementId",
                table: "CategoriaMovis",
                column: "TypeMovementId",
                principalTable: "TipoMovimentacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_TipoMovimentacao_TipoMovimentacaoId",
                table: "Movimentacao",
                column: "TipoMovimentacaoId",
                principalTable: "TipoMovimentacao",
                principalColumn: "Id");
        }
    }
}
