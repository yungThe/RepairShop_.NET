using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repair_shop.Migrations
{
    public partial class setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LinhKien",
                columns: table => new
                {
                    partID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    partName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    partInStock = table.Column<int>(type: "int", nullable: false),
                    partDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhKien", x => x.partID);
                });

            migrationBuilder.CreateTable(
                name: "ThanhVien",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhVien", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Xe",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hangXe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenXe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NVKho",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thanhVienid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVKho", x => x.id);
                    table.ForeignKey(
                        name: "FK_NVKho_ThanhVien_thanhVienid",
                        column: x => x.thanhVienid,
                        principalTable: "ThanhVien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NVKT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thanhvienid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVKT", x => x.id);
                    table.ForeignKey(
                        name: "FK_NVKT_ThanhVien_thanhvienid",
                        column: x => x.thanhvienid,
                        principalTable: "ThanhVien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonTam",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    khachhangid = table.Column<int>(type: "int", nullable: false),
                    xeid = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonTam", x => x.id);
                    table.ForeignKey(
                        name: "FK_HoaDonTam_KhachHang_khachhangid",
                        column: x => x.khachhangid,
                        principalTable: "KhachHang",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonTam_Xe_xeid",
                        column: x => x.xeid,
                        principalTable: "Xe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangXes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    khachHangid = table.Column<int>(type: "int", nullable: false),
                    Xeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangXes", x => x.id);
                    table.ForeignKey(
                        name: "FK_KhachHangXes_KhachHang_khachHangid",
                        column: x => x.khachHangid,
                        principalTable: "KhachHang",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhachHangXes_Xe_Xeid",
                        column: x => x.Xeid,
                        principalTable: "Xe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "linhKienXes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    linhKienspartID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    xeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linhKienXes", x => x.id);
                    table.ForeignKey(
                        name: "FK_linhKienXes_LinhKien_linhKienspartID",
                        column: x => x.linhKienspartID,
                        principalTable: "LinhKien",
                        principalColumn: "partID");
                    table.ForeignKey(
                        name: "FK_linhKienXes_Xe_xeid",
                        column: x => x.xeid,
                        principalTable: "Xe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonGiao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HDTid = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonGiao", x => x.id);
                    table.ForeignKey(
                        name: "FK_HoaDonGiao_HoaDonTam_HDTid",
                        column: x => x.HDTid,
                        principalTable: "HoaDonTam",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "HoaDonTamLinhKienXe",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoaDonTamid = table.Column<int>(type: "int", nullable: false),
                    linhKienXeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonTamLinhKienXe", x => x.id);
                    table.ForeignKey(
                        name: "FK_HoaDonTamLinhKienXe_HoaDonTam_hoaDonTamid",
                        column: x => x.hoaDonTamid,
                        principalTable: "HoaDonTam",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonTamLinhKienXe_linhKienXes_linhKienXeid",
                        column: x => x.linhKienXeid,
                        principalTable: "linhKienXes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonGiao_HDTid",
                table: "HoaDonGiao",
                column: "HDTid");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonTam_khachhangid",
                table: "HoaDonTam",
                column: "khachhangid");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonTam_xeid",
                table: "HoaDonTam",
                column: "xeid");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonTamLinhKiens_HoaDonTamid",
                table: "hoaDonTamLinhKiens",
                column: "HoaDonTamid");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonTamLinhKiens_linhKienpartID",
                table: "hoaDonTamLinhKiens",
                column: "linhKienpartID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonTamLinhKienXe_hoaDonTamid",
                table: "HoaDonTamLinhKienXe",
                column: "hoaDonTamid");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonTamLinhKienXe_linhKienXeid",
                table: "HoaDonTamLinhKienXe",
                column: "linhKienXeid");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangXes_khachHangid",
                table: "KhachHangXes",
                column: "khachHangid");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangXes_Xeid",
                table: "KhachHangXes",
                column: "Xeid");

            migrationBuilder.CreateIndex(
                name: "IX_linhKienXes_linhKienspartID",
                table: "linhKienXes",
                column: "linhKienspartID");

            migrationBuilder.CreateIndex(
                name: "IX_linhKienXes_xeid",
                table: "linhKienXes",
                column: "xeid");

            migrationBuilder.CreateIndex(
                name: "IX_NVKho_thanhVienid",
                table: "NVKho",
                column: "thanhVienid");

            migrationBuilder.CreateIndex(
                name: "IX_NVKT_thanhvienid",
                table: "NVKT",
                column: "thanhvienid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonGiao");

            migrationBuilder.DropTable(
                name: "hoaDonTamLinhKiens");

            migrationBuilder.DropTable(
                name: "HoaDonTamLinhKienXe");

            migrationBuilder.DropTable(
                name: "KhachHangXes");

            migrationBuilder.DropTable(
                name: "NVKho");

            migrationBuilder.DropTable(
                name: "NVKT");

            migrationBuilder.DropTable(
                name: "HoaDonTam");

            migrationBuilder.DropTable(
                name: "linhKienXes");

            migrationBuilder.DropTable(
                name: "ThanhVien");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "LinhKien");

            migrationBuilder.DropTable(
                name: "Xe");
        }
    }
}
