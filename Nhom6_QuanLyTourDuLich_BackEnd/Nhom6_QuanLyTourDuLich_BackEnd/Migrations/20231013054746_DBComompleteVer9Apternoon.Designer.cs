﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;

#nullable disable

namespace Nhom6_QuanLyTourDuLich_BackEnd.Migrations
{
    [DbContext(typeof(QuanLyTourDuLich_DBContext))]
    [Migration("20231013054746_DBComompleteVer9Apternoon")]
    partial class DBComompleteVer9Apternoon
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.ChiTietChuongTrinhTourEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdChiTietChuongTrinhTour");

                    b.Property<string>("diemDen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diemKhoiHanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hinhAnh")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("ImageDefault.png");

                    b.Property<string>("maKhachSan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maTour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("moTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phuongTien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("thoiGianBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("thoiGianKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("tieuDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .HasName("PK_ChiTietChuongTrinhTour");

                    b.HasIndex("maKhachSan");

                    b.HasIndex("maTour");

                    b.HasIndex("tieuDe")
                        .IsUnique();

                    b.ToTable("ChiTietChuongTrinhTour", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.ChuyenBayEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdChuyenBay");

                    b.Property<DateTime>("gioDen")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("gioKhoiHanh")
                        .HasColumnType("datetime2");

                    b.Property<string>("hangBay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("khuHoi")
                        .HasColumnType("bit");

                    b.Property<string>("maChuyenVe")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("mayBay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noiDen")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("noiKhoiHanh")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("trangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id")
                        .HasName("PK_ChuyenBay");

                    b.HasIndex("maChuyenVe");

                    b.HasIndex("noiDen");

                    b.HasIndex("noiKhoiHanh");

                    b.ToTable("ChuyenBay", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.DanhMucHinhEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdDanhMucHinh");

                    b.Property<string>("fileName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("ImageDefault.png");

                    b.Property<string>("maTour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .HasName("PK_DanhMucHinh");

                    b.HasIndex("maTour");

                    b.ToTable("DanhMucHinh", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.DatTourEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdDatTour");

                    b.Property<string>("maHuongDanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maKhach")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maTour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngayDat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(3499));

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<bool>("trangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id")
                        .HasName("PK_DatTour");

                    b.HasIndex("maHuongDanVien");

                    b.HasIndex("maKhach");

                    b.HasIndex("maTour");

                    b.ToTable("DatTour", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdKhachHang");

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("hoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("id_Xa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTaiKhoan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_KhachHang");

                    b.HasIndex("maTaiKhoan")
                        .IsUnique()
                        .HasFilter("[maTaiKhoan] IS NOT NULL");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachSanEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdKhachSan");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hangSao")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("0");

                    b.Property<string>("id_Xa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenKhachSan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_KhachSan");

                    b.ToTable("KhachSan", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiNhanVienEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdLoaiNhanVien");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_LoaiNhanVien");

                    b.ToTable("LoaiNhanVien", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiTaiKhoanEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdLoaiTaiKhoan");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_LoaiTaiKhoan");

                    b.ToTable("LoaiTaiKhoan", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiTourEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdLoaiTour");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_LoaiTour");

                    b.ToTable("LoaiTour", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.NhanVienEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdNhanVien");

                    b.Property<string>("canCuocConDan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("maLoaiNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValue("0");

                    b.Property<string>("maTaiKhoan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayVaoLam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(5867));

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id")
                        .HasName("PK_NhanVien");

                    b.HasIndex("maLoaiNhanVien");

                    b.HasIndex("maTaiKhoan")
                        .IsUnique()
                        .HasFilter("[maTaiKhoan] IS NOT NULL");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.SanBayEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdSanBay");

                    b.Property<string>("tenSanBay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_SanBay");

                    b.ToTable("SanBay", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TaiKhoanEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdTaiKhoan");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngayLap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 13, 12, 47, 46, 203, DateTimeKind.Local).AddTicks(7919));

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("trangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id")
                        .HasName("PK_TaiKhoan");

                    b.HasIndex("email")
                        .IsUnique();

                    b.HasIndex("maLoai");

                    b.HasIndex("soDienThoai")
                        .IsUnique();

                    b.ToTable("TaiKhoan", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.ThanhVienEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdThanhVien");

                    b.Property<string>("canCuocConDan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("hoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maDatTour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("PK_ThanhVien");

                    b.HasIndex("maDatTour");

                    b.ToTable("ThanhVien", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdTour");

                    b.Property<string>("anhBia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("chiPhi")
                        .HasColumnType("float");

                    b.Property<string>("maChuyenBay")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maKhachSan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maLoaiTour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("moTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayLap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 13, 12, 47, 46, 204, DateTimeKind.Local).AddTicks(4625));

                    b.Property<string>("nguoiLap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("phuongTienDiChuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("trangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id")
                        .HasName("PK_Tour");

                    b.HasIndex("maChuyenBay");

                    b.HasIndex("maKhachSan");

                    b.HasIndex("maLoaiTour");

                    b.HasIndex("nguoiLap");

                    b.HasIndex("tenTour")
                        .IsUnique();

                    b.ToTable("Tour", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.ChiTietChuongTrinhTourEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachSanEntity", "KhachSan")
                        .WithMany()
                        .HasForeignKey("maKhachSan");

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", "Tour")
                        .WithMany()
                        .HasForeignKey("maTour")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachSan");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.ChuyenBayEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.ChuyenBayEntity", "ChuyenBay")
                        .WithMany()
                        .HasForeignKey("maChuyenVe");

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.SanBayEntity", "SanBayDen")
                        .WithMany()
                        .HasForeignKey("noiDen");

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.SanBayEntity", "SanBayDi")
                        .WithMany()
                        .HasForeignKey("noiKhoiHanh");

                    b.Navigation("ChuyenBay");

                    b.Navigation("SanBayDen");

                    b.Navigation("SanBayDi");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.DanhMucHinhEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", "Tour")
                        .WithMany("DanhMucHinhs")
                        .HasForeignKey("maTour")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.DatTourEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.NhanVienEntity", "HuongDanVien")
                        .WithMany()
                        .HasForeignKey("maHuongDanVien");

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", "KhachHang")
                        .WithMany("Tours")
                        .HasForeignKey("maKhach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", "Tour")
                        .WithMany()
                        .HasForeignKey("maTour")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HuongDanVien");

                    b.Navigation("KhachHang");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.TaiKhoanEntity", "TaiKhoan")
                        .WithMany()
                        .HasForeignKey("maTaiKhoan");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.NhanVienEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiNhanVienEntity", "LoaiNhanVien")
                        .WithMany("NhanViens")
                        .HasForeignKey("maLoaiNhanVien");

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.TaiKhoanEntity", "TaiKhoan")
                        .WithMany()
                        .HasForeignKey("maTaiKhoan");

                    b.Navigation("LoaiNhanVien");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TaiKhoanEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiTaiKhoanEntity", "LoaiTaiKhoan")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("maLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiTaiKhoan");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.ThanhVienEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.DatTourEntity", "DatTour")
                        .WithMany("ThanhViens")
                        .HasForeignKey("maDatTour")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DatTour");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.ChuyenBayEntity", "ChuyenBay")
                        .WithMany()
                        .HasForeignKey("maChuyenBay");

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachSanEntity", "KhachSan")
                        .WithMany()
                        .HasForeignKey("maKhachSan");

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiTourEntity", "LoaiTour")
                        .WithMany("Tours")
                        .HasForeignKey("maLoaiTour")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.NhanVienEntity", "NhanVien")
                        .WithMany()
                        .HasForeignKey("nguoiLap");

                    b.Navigation("ChuyenBay");

                    b.Navigation("KhachSan");

                    b.Navigation("LoaiTour");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.DatTourEntity", b =>
                {
                    b.Navigation("ThanhViens");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiNhanVienEntity", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiTaiKhoanEntity", b =>
                {
                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiTourEntity", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", b =>
                {
                    b.Navigation("DanhMucHinhs");
                });
#pragma warning restore 612, 618
        }
    }
}
