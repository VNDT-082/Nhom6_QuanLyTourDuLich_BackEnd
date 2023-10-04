using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DbCompleteVer3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhachHang_TaiKhoan_maTaiKhoan",
                table: "KhachHang");

            migrationBuilder.DropForeignKey(
                name: "FK_KhachHang_Xa_id_Xa",
                table: "KhachHang");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_LoaiNhanVien_maLoaiNhanVien",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_maTaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_KhachHang_maTaiKhoan",
                table: "KhachHang");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 15, 26, 47, 757, DateTimeKind.Local).AddTicks(5336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.AlterColumn<string>(
                name: "canCuocConDan",
                table: "ThanhVien",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 4, 15, 26, 47, 757, DateTimeKind.Local).AddTicks(4245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 15, 26, 47, 757, DateTimeKind.Local).AddTicks(2199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.AlterColumn<string>(
                name: "maLoaiNhanVien",
                table: "NhanVien",
                type: "nvarchar(450)",
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "soDienThoai",
                table: "KhachSan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "maTaiKhoan",
                table: "KhachHang",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "id_Xa",
                table: "KhachHang",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "diaChi",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 15, 26, 47, 757, DateTimeKind.Local).AddTicks(900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.AlterColumn<string>(
                name: "phuongTien",
                table: "ChiTietChuongTrinhTour",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "maKhachSan",
                table: "ChiTietChuongTrinhTour",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_maTaiKhoan",
                table: "NhanVien",
                column: "maTaiKhoan",
                unique: true,
                filter: "[maTaiKhoan] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_maTaiKhoan",
                table: "KhachHang",
                column: "maTaiKhoan",
                unique: true,
                filter: "[maTaiKhoan] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHang_TaiKhoan_maTaiKhoan",
                table: "KhachHang",
                column: "maTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHang_Xa_id_Xa",
                table: "KhachHang",
                column: "id_Xa",
                principalTable: "Xa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_LoaiNhanVien_maLoaiNhanVien",
                table: "NhanVien",
                column: "maLoaiNhanVien",
                principalTable: "LoaiNhanVien",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhachHang_TaiKhoan_maTaiKhoan",
                table: "KhachHang");

            migrationBuilder.DropForeignKey(
                name: "FK_KhachHang_Xa_id_Xa",
                table: "KhachHang");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_LoaiNhanVien_maLoaiNhanVien",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_maTaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_KhachHang_maTaiKhoan",
                table: "KhachHang");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(5122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 15, 26, 47, 757, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.AlterColumn<string>(
                name: "canCuocConDan",
                table: "ThanhVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(3975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 4, 15, 26, 47, 757, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(2055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 15, 26, 47, 757, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.AlterColumn<string>(
                name: "maLoaiNhanVien",
                table: "NhanVien",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "soDienThoai",
                table: "KhachSan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "maTaiKhoan",
                table: "KhachHang",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id_Xa",
                table: "KhachHang",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "diaChi",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(1078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 15, 26, 47, 757, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.AlterColumn<string>(
                name: "phuongTien",
                table: "ChiTietChuongTrinhTour",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "maKhachSan",
                table: "ChiTietChuongTrinhTour",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_maTaiKhoan",
                table: "NhanVien",
                column: "maTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_maTaiKhoan",
                table: "KhachHang",
                column: "maTaiKhoan");

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHang_TaiKhoan_maTaiKhoan",
                table: "KhachHang",
                column: "maTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHang_Xa_id_Xa",
                table: "KhachHang",
                column: "id_Xa",
                principalTable: "Xa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_LoaiNhanVien_maLoaiNhanVien",
                table: "NhanVien",
                column: "maLoaiNhanVien",
                principalTable: "LoaiNhanVien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
