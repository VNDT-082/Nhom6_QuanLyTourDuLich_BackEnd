using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DBCompleteVer11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "thoiGianBatDau",
                table: "ChiTietChuongTrinhTour");

            migrationBuilder.DropColumn(
                name: "thoiGianKetThuc",
                table: "ChiTietChuongTrinhTour");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(5661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 13, 58, 14, 513, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(4105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 13, 13, 58, 14, 513, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 13, 58, 14, 513, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 678, DateTimeKind.Local).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 13, 58, 14, 513, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.AddColumn<string>(
                name: "buaAn",
                table: "ChiTietChuongTrinhTour",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ngayThu",
                table: "ChiTietChuongTrinhTour",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "buaAn",
                table: "ChiTietChuongTrinhTour");

            migrationBuilder.DropColumn(
                name: "ngayThu",
                table: "ChiTietChuongTrinhTour");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 13, 58, 14, 513, DateTimeKind.Local).AddTicks(8638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 13, 13, 58, 14, 513, DateTimeKind.Local).AddTicks(6880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 13, 58, 14, 513, DateTimeKind.Local).AddTicks(4624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 13, 58, 14, 513, DateTimeKind.Local).AddTicks(2179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 678, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.AddColumn<DateTime>(
                name: "thoiGianBatDau",
                table: "ChiTietChuongTrinhTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "thoiGianKetThuc",
                table: "ChiTietChuongTrinhTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
