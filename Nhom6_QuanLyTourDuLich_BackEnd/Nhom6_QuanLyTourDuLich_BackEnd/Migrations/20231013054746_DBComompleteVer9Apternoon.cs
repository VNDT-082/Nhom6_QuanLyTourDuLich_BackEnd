using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DBComompleteVer9Apternoon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tour",
                newName: "IdTour");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ThanhVien",
                newName: "IdThanhVien");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TaiKhoan",
                newName: "IdTaiKhoan");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SanBay",
                newName: "IdSanBay");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NhanVien",
                newName: "IdNhanVien");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LoaiTour",
                newName: "IdLoaiTour");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LoaiTaiKhoan",
                newName: "IdLoaiTaiKhoan");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LoaiNhanVien",
                newName: "IdLoaiNhanVien");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "KhachSan",
                newName: "IdKhachSan");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "KhachHang",
                newName: "IdKhachHang");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DatTour",
                newName: "IdDatTour");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DanhMucHinh",
                newName: "IdDanhMucHinh");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ChuyenBay",
                newName: "IdChuyenBay");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ChiTietChuongTrinhTour",
                newName: "IdChiTietChuongTrinhTour");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 47, 46, 204, DateTimeKind.Local).AddTicks(4625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 1, 52, 46, 606, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(7919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 13, 1, 52, 46, 605, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(5867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 1, 52, 46, 605, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(3499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 1, 52, 46, 605, DateTimeKind.Local).AddTicks(5281));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdTour",
                table: "Tour",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdThanhVien",
                table: "ThanhVien",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdTaiKhoan",
                table: "TaiKhoan",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdSanBay",
                table: "SanBay",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdNhanVien",
                table: "NhanVien",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdLoaiTour",
                table: "LoaiTour",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdLoaiTaiKhoan",
                table: "LoaiTaiKhoan",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdLoaiNhanVien",
                table: "LoaiNhanVien",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdKhachSan",
                table: "KhachSan",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdKhachHang",
                table: "KhachHang",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdDatTour",
                table: "DatTour",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdDanhMucHinh",
                table: "DanhMucHinh",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdChuyenBay",
                table: "ChuyenBay",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdChiTietChuongTrinhTour",
                table: "ChiTietChuongTrinhTour",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 1, 52, 46, 606, DateTimeKind.Local).AddTicks(612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 47, 46, 204, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 13, 1, 52, 46, 605, DateTimeKind.Local).AddTicks(9291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 1, 52, 46, 605, DateTimeKind.Local).AddTicks(7333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 1, 52, 46, 605, DateTimeKind.Local).AddTicks(5281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(3499));
        }
    }
}
