using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hafta10.Migrations
{
    /// <inheritdoc />
    public partial class ikinci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OgrenciId1",
                table: "Not",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Not_OgrenciId1",
                table: "Not",
                column: "OgrenciId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Not_Ogrenci_OgrenciId1",
                table: "Not",
                column: "OgrenciId1",
                principalTable: "Ogrenci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Not_Ogrenci_OgrenciId1",
                table: "Not");

            migrationBuilder.DropIndex(
                name: "IX_Not_OgrenciId1",
                table: "Not");

            migrationBuilder.DropColumn(
                name: "OgrenciId1",
                table: "Not");
        }
    }
}
