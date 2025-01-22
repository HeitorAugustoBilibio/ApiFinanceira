using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class nomeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaMovis_TipoMovimentacao_MovementTypeId",
                table: "CategoriaMovis");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_TipoMovimentacao_MovementTypeId",
                table: "Movimentacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoMovimentacao",
                table: "TipoMovimentacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimentacao",
                table: "Movimentacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriaMovis",
                table: "CategoriaMovis");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "TipoMovimentacao",
                newName: "MovementTypes");

            migrationBuilder.RenameTable(
                name: "Movimentacao",
                newName: "Movements");

            migrationBuilder.RenameTable(
                name: "CategoriaMovis",
                newName: "CategoryMovements");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentacao_MovementTypeId",
                table: "Movements",
                newName: "IX_Movements_MovementTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaMovis_MovementTypeId",
                table: "CategoryMovements",
                newName: "IX_CategoryMovements_MovementTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovementTypes",
                table: "MovementTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movements",
                table: "Movements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryMovements",
                table: "CategoryMovements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMovements_MovementTypes_MovementTypeId",
                table: "CategoryMovements",
                column: "MovementTypeId",
                principalTable: "MovementTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movements_MovementTypes_MovementTypeId",
                table: "Movements",
                column: "MovementTypeId",
                principalTable: "MovementTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMovements_MovementTypes_MovementTypeId",
                table: "CategoryMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_Movements_MovementTypes_MovementTypeId",
                table: "Movements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovementTypes",
                table: "MovementTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movements",
                table: "Movements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryMovements",
                table: "CategoryMovements");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "MovementTypes",
                newName: "TipoMovimentacao");

            migrationBuilder.RenameTable(
                name: "Movements",
                newName: "Movimentacao");

            migrationBuilder.RenameTable(
                name: "CategoryMovements",
                newName: "CategoriaMovis");

            migrationBuilder.RenameIndex(
                name: "IX_Movements_MovementTypeId",
                table: "Movimentacao",
                newName: "IX_Movimentacao_MovementTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryMovements_MovementTypeId",
                table: "CategoriaMovis",
                newName: "IX_CategoriaMovis_MovementTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoMovimentacao",
                table: "TipoMovimentacao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimentacao",
                table: "Movimentacao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriaMovis",
                table: "CategoriaMovis",
                column: "Id");

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
    }
}
