using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DbCompleteVer2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(5122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.AddColumn<string>(
                name: "maKhachSan",
                table: "Tour",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "trangThai",
                table: "TaiKhoan",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(3975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(2055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.AlterColumn<string>(
                name: "maTaiKhoan",
                table: "NhanVien",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(1078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.CreateIndex(
                name: "IX_Tour_maKhachSan",
                table: "Tour",
                column: "maKhachSan");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_maTaiKhoan",
                table: "NhanVien",
                column: "maTaiKhoan");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_TaiKhoan_maTaiKhoan",
                table: "NhanVien",
                column: "maTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_KhachSan_maKhachSan",
                table: "Tour",
                column: "maKhachSan",
                principalTable: "KhachSan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_TaiKhoan_maTaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_Tour_KhachSan_maKhachSan",
                table: "Tour");

            migrationBuilder.DropIndex(
                name: "IX_Tour_maKhachSan",
                table: "Tour");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_maTaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "maKhachSan",
                table: "Tour");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(3429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.AlterColumn<bool>(
                name: "trangThai",
                table: "TaiKhoan",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(2347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(1088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.AlterColumn<string>(
                name: "maTaiKhoan",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 15, 44, 32, 536, DateTimeKind.Local).AddTicks(147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 16, 25, 38, 448, DateTimeKind.Local).AddTicks(1078));
        }
    }
}
