using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DBCompleteVer6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhachHang_Xa_id_Xa",
                table: "KhachHang");

            migrationBuilder.DropTable(
                name: "Xa");

            migrationBuilder.DropTable(
                name: "Huyen");

            migrationBuilder.DropTable(
                name: "Tinh");

            migrationBuilder.DropIndex(
                name: "IX_KhachHang_id_Xa",
                table: "KhachHang");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 16, 13, 34, 191, DateTimeKind.Local).AddTicks(7789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 17, 0, 56, 170, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 11, 16, 13, 34, 191, DateTimeKind.Local).AddTicks(6651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 4, 17, 0, 56, 170, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 16, 13, 34, 191, DateTimeKind.Local).AddTicks(4790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 17, 0, 56, 170, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.AddColumn<string>(
                name: "diaChi",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "id_Xa",
                table: "KhachHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 16, 13, 34, 191, DateTimeKind.Local).AddTicks(3469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 17, 0, 56, 169, DateTimeKind.Local).AddTicks(9021));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diaChi",
                table: "NhanVien");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "Tour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 17, 0, 56, 170, DateTimeKind.Local).AddTicks(3672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 16, 13, 34, 191, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayLap",
                table: "TaiKhoan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 10, 4, 17, 0, 56, 170, DateTimeKind.Local).AddTicks(2499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 10, 11, 16, 13, 34, 191, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayVaoLam",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 17, 0, 56, 170, DateTimeKind.Local).AddTicks(617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 16, 13, 34, 191, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.AlterColumn<string>(
                name: "id_Xa",
                table: "KhachHang",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayDat",
                table: "DatTour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 17, 0, 56, 169, DateTimeKind.Local).AddTicks(9021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 16, 13, 34, 191, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.CreateTable(
                name: "Tinh",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenTinh = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tinh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Huyen",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maTinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenHuyen = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huyen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Huyen_Tinh_maTinh",
                        column: x => x.maTinh,
                        principalTable: "Tinh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Xa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maHuyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenXa = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xa_Huyen_maHuyen",
                        column: x => x.maHuyen,
                        principalTable: "Huyen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_id_Xa",
                table: "KhachHang",
                column: "id_Xa");

            migrationBuilder.CreateIndex(
                name: "IX_Huyen_maTinh",
                table: "Huyen",
                column: "maTinh");

            migrationBuilder.CreateIndex(
                name: "IX_Huyen_tenHuyen",
                table: "Huyen",
                column: "tenHuyen",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tinh_tenTinh",
                table: "Tinh",
                column: "tenTinh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Xa_maHuyen",
                table: "Xa",
                column: "maHuyen");

            migrationBuilder.CreateIndex(
                name: "IX_Xa_tenXa",
                table: "Xa",
                column: "tenXa",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHang_Xa_id_Xa",
                table: "KhachHang",
                column: "id_Xa",
                principalTable: "Xa",
                principalColumn: "Id");
        }
    }
}
