using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repair_shop.Migrations
{
    public partial class setup1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonTamLinhKienXe_HoaDonTam_hoaDonTamid",
                table: "HoaDonTamLinhKienXe");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonTamLinhKienXe_linhKienXes_linhKienXeid",
                table: "HoaDonTamLinhKienXe");

            migrationBuilder.DropTable(
                name: "hoaDonTamLinhKiens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonTamLinhKienXe",
                table: "HoaDonTamLinhKienXe");

            migrationBuilder.RenameTable(
                name: "HoaDonTamLinhKienXe",
                newName: "hoaDonTamLinhKienxes");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDonTamLinhKienXe_linhKienXeid",
                table: "hoaDonTamLinhKienxes",
                newName: "IX_hoaDonTamLinhKienxes_linhKienXeid");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDonTamLinhKienXe_hoaDonTamid",
                table: "hoaDonTamLinhKienxes",
                newName: "IX_hoaDonTamLinhKienxes_hoaDonTamid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDonTamLinhKienxes",
                table: "hoaDonTamLinhKienxes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonTamLinhKienxes_HoaDonTam_hoaDonTamid",
                table: "hoaDonTamLinhKienxes",
                column: "hoaDonTamid",
                principalTable: "HoaDonTam",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonTamLinhKienxes_linhKienXes_linhKienXeid",
                table: "hoaDonTamLinhKienxes",
                column: "linhKienXeid",
                principalTable: "linhKienXes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonTamLinhKienxes_HoaDonTam_hoaDonTamid",
                table: "hoaDonTamLinhKienxes");

            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonTamLinhKienxes_linhKienXes_linhKienXeid",
                table: "hoaDonTamLinhKienxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDonTamLinhKienxes",
                table: "hoaDonTamLinhKienxes");

            migrationBuilder.RenameTable(
                name: "hoaDonTamLinhKienxes",
                newName: "HoaDonTamLinhKienXe");

            migrationBuilder.RenameIndex(
                name: "IX_hoaDonTamLinhKienxes_linhKienXeid",
                table: "HoaDonTamLinhKienXe",
                newName: "IX_HoaDonTamLinhKienXe_linhKienXeid");

            migrationBuilder.RenameIndex(
                name: "IX_hoaDonTamLinhKienxes_hoaDonTamid",
                table: "HoaDonTamLinhKienXe",
                newName: "IX_HoaDonTamLinhKienXe_hoaDonTamid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonTamLinhKienXe",
                table: "HoaDonTamLinhKienXe",
                column: "id");

            migrationBuilder.CreateTable(
                name: "hoaDonTamLinhKiens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonTamid = table.Column<int>(type: "int", nullable: false),
                    linhKienpartID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    soluong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonTamLinhKiens", x => x.id);
                    table.ForeignKey(
                        name: "FK_hoaDonTamLinhKiens_HoaDonTam_HoaDonTamid",
                        column: x => x.HoaDonTamid,
                        principalTable: "HoaDonTam",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonTamLinhKiens_LinhKien_linhKienpartID",
                        column: x => x.linhKienpartID,
                        principalTable: "LinhKien",
                        principalColumn: "partID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonTamLinhKiens_HoaDonTamid",
                table: "hoaDonTamLinhKiens",
                column: "HoaDonTamid");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonTamLinhKiens_linhKienpartID",
                table: "hoaDonTamLinhKiens",
                column: "linhKienpartID");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonTamLinhKienXe_HoaDonTam_hoaDonTamid",
                table: "HoaDonTamLinhKienXe",
                column: "hoaDonTamid",
                principalTable: "HoaDonTam",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonTamLinhKienXe_linhKienXes_linhKienXeid",
                table: "HoaDonTamLinhKienXe",
                column: "linhKienXeid",
                principalTable: "linhKienXes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
