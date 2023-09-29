using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class DBInitialTinhHuyenXa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    tenHuyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maTinh = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    tenXa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maHuyen = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

            var sp = @"CREATE PROCEDURE [dbo].[InsertOneTaiKhoan]
                    @FirstName varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Students where FirstName like @FirstName +'%'
                END";
            migrationBuilder.Sql(sp);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Xa");

            migrationBuilder.DropTable(
                name: "Huyen");

            migrationBuilder.DropTable(
                name: "Tinh");
        }
    }
}
