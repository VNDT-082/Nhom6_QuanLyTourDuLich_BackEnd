using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DBCompleteVer12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ChiTietChuongTrinhTour_tieuDe",
                table: "ChiTietChuongTrinhTour");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 745, DateTimeKind.Local).AddTicks(1867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(9877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(7277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 678, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.AlterColumn<string>(
                name: "tieuDe",
                table: "ChiTietChuongTrinhTour",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(5661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 745, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(4105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 679, DateTimeKind.Local).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 0, 31, 57, 678, DateTimeKind.Local).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.AlterColumn<string>(
                name: "tieuDe",
                table: "ChiTietChuongTrinhTour",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietChuongTrinhTour_tieuDe",
                table: "ChiTietChuongTrinhTour",
                column: "tieuDe",
                unique: true);
        }
    }
}
