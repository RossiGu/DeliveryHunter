using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryHunter.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                table: "produtos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "produtos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                table: "produtos",
                column: "CategoriaId",
                principalTable: "categorias",
                principalColumn: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                table: "produtos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "produtos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                table: "produtos",
                column: "CategoriaId",
                principalTable: "categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
