using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DBUpdateVer14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayTraLoi",
                table: "TraLoiHoiDap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 629, DateTimeKind.Local).AddTicks(1057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(9060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDang",
                table: "NhanXet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(9792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(1832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDang",
                table: "HoiDap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 629, DateTimeKind.Local).AddTicks(486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.AlterColumn<bool>(
                name: "trangThai",
                table: "DatTour",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 627, DateTimeKind.Local).AddTicks(5749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(1695));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayTraLoi",
                table: "TraLoiHoiDap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(9003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 629, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(7698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(6205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDang",
                table: "NhanXet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(8210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(4000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDang",
                table: "HoiDap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(8596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 629, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.AlterColumn<bool>(
                name: "trangThai",
                table: "DatTour",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(1695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 627, DateTimeKind.Local).AddTicks(5749));
        }
    }
}
