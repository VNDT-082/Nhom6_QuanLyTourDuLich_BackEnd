using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DBCompleteVer13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(7698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 745, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(6205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(4000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(1695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.CreateTable(
                name: "HoiDap",
                columns: table => new
                {
                    IdHoiDap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdNguoiDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdTour = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ngayDang = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(8596)),
                    noiDung = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoiDap", x => x.IdHoiDap);
                    table.ForeignKey(
                        name: "FK_HoiDap_KhachHang_IdNguoiDung",
                        column: x => x.IdNguoiDung,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoiDap_Tour_IdTour",
                        column: x => x.IdTour,
                        principalTable: "Tour",
                        principalColumn: "IdTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanXet",
                columns: table => new
                {
                    IdNhanXet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdNguoiDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdTour = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ngayDang = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(8210)),
                    noiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    danhGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanXet", x => x.IdNhanXet);
                    table.ForeignKey(
                        name: "FK_NhanXet_KhachHang_IdNguoiDung",
                        column: x => x.IdNguoiDung,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanXet_Tour_IdTour",
                        column: x => x.IdTour,
                        principalTable: "Tour",
                        principalColumn: "IdTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraLoiHoiDap",
                columns: table => new
                {
                    IdTraLoiHoiDap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdHoiDap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ngayTraLoi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(9003)),
                    noiDung = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraLoiHoiDap", x => x.IdTraLoiHoiDap);
                    table.ForeignKey(
                        name: "FK_TraLoiHoiDap_HoiDap_IdHoiDap",
                        column: x => x.IdHoiDap,
                        principalTable: "HoiDap",
                        principalColumn: "IdHoiDap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraLoiHoiDap_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachHang");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoiDap_IdNguoiDung",
                table: "HoiDap",
                column: "IdNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_HoiDap_IdTour",
                table: "HoiDap",
                column: "IdTour");

            migrationBuilder.CreateIndex(
                name: "IX_NhanXet_IdNguoiDung",
                table: "NhanXet",
                column: "IdNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_NhanXet_IdTour",
                table: "NhanXet",
                column: "IdTour");

            migrationBuilder.CreateIndex(
                name: "IX_TraLoiHoiDap_IdHoiDap",
                table: "TraLoiHoiDap",
                column: "IdHoiDap");

            migrationBuilder.CreateIndex(
                name: "IX_TraLoiHoiDap_IdKhachHang",
                table: "TraLoiHoiDap",
                column: "IdKhachHang");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanXet");

            migrationBuilder.DropTable(
                name: "TraLoiHoiDap");

            migrationBuilder.DropTable(
                name: "HoiDap");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 745, DateTimeKind.Local).AddTicks(1867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(9877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(7277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 15, 38, 2, 744, DateTimeKind.Local).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 21, 15, 5, 56, 650, DateTimeKind.Local).AddTicks(1695));
        }
    }
}
