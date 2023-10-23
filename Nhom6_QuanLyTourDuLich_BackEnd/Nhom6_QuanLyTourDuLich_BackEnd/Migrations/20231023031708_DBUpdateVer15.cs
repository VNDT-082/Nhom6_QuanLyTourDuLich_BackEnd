using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DBUpdateVer15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayTraLoi",
                table: "TraLoiHoiDap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(7671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 629, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(6093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDang",
                table: "NhanXet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(6687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(1452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDang",
                table: "HoiDap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(7212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 629, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 406, DateTimeKind.Local).AddTicks(8445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 627, DateTimeKind.Local).AddTicks(5749));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayTraLoi",
                table: "TraLoiHoiDap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 629, DateTimeKind.Local).AddTicks(1057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(9060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDang",
                table: "NhanXet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(9792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 628, DateTimeKind.Local).AddTicks(1832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDang",
                table: "HoiDap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 629, DateTimeKind.Local).AddTicks(486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 9, 55, 11, 627, DateTimeKind.Local).AddTicks(5749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 17, 8, 406, DateTimeKind.Local).AddTicks(8445));
        }
    }
}
