using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DbCompleteVer1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoan_LoaiTaiKhoanEntity_maLoai",
                table: "TaiKhoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiTaiKhoanEntity",
                table: "LoaiTaiKhoanEntity");

            migrationBuilder.RenameTable(
                name: "LoaiTaiKhoanEntity",
                newName: "LoaiTaiKhoan");

            migrationBuilder.AlterColumn<bool>(
                name: "trangThai",
                table: "TaiKhoan",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiTaiKhoan",
                table: "LoaiTaiKhoan",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_Xa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    soDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maTaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhachHang_TaiKhoan_maTaiKhoan",
                        column: x => x.maTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhachHang_Xa_id_Xa",
                        column: x => x.id_Xa,
                        principalTable: "Xa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachSan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenKhachSan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hangSao = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "0"),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_Xa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachSan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiNhanVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiNhanVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTour",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTour", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanBay",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenSanBay = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanBay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maLoaiNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValue: "0"),
                    tenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    soDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(1088)),
                    canCuocConDan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_LoaiNhanVien_maLoaiNhanVien",
                        column: x => x.maLoaiNhanVien,
                        principalTable: "LoaiNhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenBay",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hangBay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioKhoiHanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    noiKhoiHanh = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    gioDen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    noiDen = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    khuHoi = table.Column<bool>(type: "bit", nullable: false),
                    mayBay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    maChuyenVe = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenBay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChuyenBay_ChuyenBay_maChuyenVe",
                        column: x => x.maChuyenVe,
                        principalTable: "ChuyenBay",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenBay_SanBay_noiDen",
                        column: x => x.noiDen,
                        principalTable: "SanBay",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenBay_SanBay_noiKhoiHanh",
                        column: x => x.noiKhoiHanh,
                        principalTable: "SanBay",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenTour = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    moTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    anhBia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chiPhi = table.Column<double>(type: "float", nullable: false),
                    ngayLap = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(3429)),
                    nguoiLap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maLoaiTour = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maChuyenBay = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    phuongTienDiChuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tour_ChuyenBay_maChuyenBay",
                        column: x => x.maChuyenBay,
                        principalTable: "ChuyenBay",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tour_LoaiTour_maLoaiTour",
                        column: x => x.maLoaiTour,
                        principalTable: "LoaiTour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tour_NhanVien_nguoiLap",
                        column: x => x.nguoiLap,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietChuongTrinhTour",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maTour = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    thoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    thoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    diemKhoiHanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diemDen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tieuDe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    moTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "ImageDefault.png"),
                    maKhachSan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phuongTien = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietChuongTrinhTour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietChuongTrinhTour_Tour_maTour",
                        column: x => x.maTour,
                        principalTable: "Tour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucHinh",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "ImageDefault.png"),
                    maTour = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucHinh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhMucHinh_Tour_maTour",
                        column: x => x.maTour,
                        principalTable: "Tour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatTour",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maKhach = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maHuongDanVien = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    maTour = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false),
                    ngayDat = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(147)),
                    trangThai = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatTour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatTour_KhachHang_maKhach",
                        column: x => x.maKhach,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatTour_NhanVien_maHuongDanVien",
                        column: x => x.maHuongDanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DatTour_Tour_maTour",
                        column: x => x.maTour,
                        principalTable: "Tour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThanhVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    canCuocConDan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maDatTour = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThanhVien_DatTour_maDatTour",
                        column: x => x.maDatTour,
                        principalTable: "DatTour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietChuongTrinhTour_maTour",
                table: "ChiTietChuongTrinhTour",
                column: "maTour");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietChuongTrinhTour_tieuDe",
                table: "ChiTietChuongTrinhTour",
                column: "tieuDe",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_maChuyenVe",
                table: "ChuyenBay",
                column: "maChuyenVe");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_noiDen",
                table: "ChuyenBay",
                column: "noiDen");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_noiKhoiHanh",
                table: "ChuyenBay",
                column: "noiKhoiHanh");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucHinh_maTour",
                table: "DanhMucHinh",
                column: "maTour");

            migrationBuilder.CreateIndex(
                name: "IX_DatTour_maHuongDanVien",
                table: "DatTour",
                column: "maHuongDanVien");

            migrationBuilder.CreateIndex(
                name: "IX_DatTour_maKhach",
                table: "DatTour",
                column: "maKhach");

            migrationBuilder.CreateIndex(
                name: "IX_DatTour_maTour",
                table: "DatTour",
                column: "maTour");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_id_Xa",
                table: "KhachHang",
                column: "id_Xa");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_maTaiKhoan",
                table: "KhachHang",
                column: "maTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_maLoaiNhanVien",
                table: "NhanVien",
                column: "maLoaiNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhVien_maDatTour",
                table: "ThanhVien",
                column: "maDatTour");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_maChuyenBay",
                table: "Tour",
                column: "maChuyenBay");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_maLoaiTour",
                table: "Tour",
                column: "maLoaiTour");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_nguoiLap",
                table: "Tour",
                column: "nguoiLap");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_tenTour",
                table: "Tour",
                column: "tenTour",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoan_LoaiTaiKhoan_maLoai",
                table: "TaiKhoan",
                column: "maLoai",
                principalTable: "LoaiTaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoan_LoaiTaiKhoan_maLoai",
                table: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "ChiTietChuongTrinhTour");

            migrationBuilder.DropTable(
                name: "DanhMucHinh");

            migrationBuilder.DropTable(
                name: "KhachSan");

            migrationBuilder.DropTable(
                name: "ThanhVien");

            migrationBuilder.DropTable(
                name: "DatTour");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "ChuyenBay");

            migrationBuilder.DropTable(
                name: "LoaiTour");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "SanBay");

            migrationBuilder.DropTable(
                name: "LoaiNhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiTaiKhoan",
                table: "LoaiTaiKhoan");

            migrationBuilder.DropColumn(
                name: "ngayLap",
                table: "TaiKhoan");

            migrationBuilder.RenameTable(
                name: "LoaiTaiKhoan",
                newName: "LoaiTaiKhoanEntity");

            migrationBuilder.AlterColumn<bool>(
                name: "trangThai",
                table: "TaiKhoan",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiTaiKhoanEntity",
                table: "LoaiTaiKhoanEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoan_LoaiTaiKhoanEntity_maLoai",
                table: "TaiKhoan",
                column: "maLoai",
                principalTable: "LoaiTaiKhoanEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
