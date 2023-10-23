﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;

#nullable disable

namespace CongNghePhanMemNangCao_Nhom6_QuanLyTourDuLich.Migrations
{
    [DbContext(typeof(QuanLyTourDuLich_DBContext))]
    partial class QuanLyTourDuLich_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.ChiTietChuongTrinhTourEntity", b =>
                {
                    b.Property<string>("IdChiTietChuongTrinhTour")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdChiTietChuongTrinhTour");

                    b.Property<string>("buaAn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("ngayThu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phuongTien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdChiTietChuongTrinhTour")
                        .HasName("PK_ChiTietChuongTrinhTour");

                    b.HasIndex("maKhachSan");

                    b.HasIndex("maTour");

                    b.ToTable("ChiTietChuongTrinhTour", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.ChuyenBayEntity", b =>
                {
                    b.Property<string>("IdChuyenBay")
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

                    b.HasKey("IdChuyenBay")
                        .HasName("PK_ChuyenBay");

                    b.HasIndex("maChuyenVe");

                    b.HasIndex("noiDen");

                    b.HasIndex("noiKhoiHanh");

                    b.ToTable("ChuyenBay", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.DanhMucHinhEntity", b =>
                {
                    b.Property<string>("IdDanhMucHinh")
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

                    b.HasKey("IdDanhMucHinh")
                        .HasName("PK_DanhMucHinh");

                    b.HasIndex("maTour");

                    b.ToTable("DanhMucHinh", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.DatTourEntity", b =>
                {
                    b.Property<string>("IdDatTour")
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
                        .HasDefaultValue(new DateTime(2023, 10, 23, 10, 17, 8, 406, DateTimeKind.Local).AddTicks(8445));

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdDatTour")
                        .HasName("PK_DatTour");

                    b.HasIndex("maHuongDanVien");

                    b.HasIndex("maKhach");

                    b.HasIndex("maTour");

                    b.ToTable("DatTour", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.HoiDapEntity", b =>
                {
                    b.Property<string>("IdHoiDap")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdHoiDap");

                    b.Property<string>("IdNguoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdTour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngayDang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(7212));

                    b.Property<string>("noiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHoiDap");

                    b.HasIndex("IdNguoiDung");

                    b.HasIndex("IdTour");

                    b.ToTable("HoiDap", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", b =>
                {
                    b.Property<string>("IdKhachHang")
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

                    b.Property<string>("maTaiKhoan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdKhachHang")
                        .HasName("PK_KhachHang");

                    b.HasIndex("maTaiKhoan")
                        .IsUnique()
                        .HasFilter("[maTaiKhoan] IS NOT NULL");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachSanEntity", b =>
                {
                    b.Property<string>("IdKhachSan")
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

                    b.Property<string>("soDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenKhachSan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdKhachSan")
                        .HasName("PK_KhachSan");

                    b.ToTable("KhachSan", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiNhanVienEntity", b =>
                {
                    b.Property<string>("IdLoaiNhanVien")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdLoaiNhanVien");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoaiNhanVien")
                        .HasName("PK_LoaiNhanVien");

                    b.ToTable("LoaiNhanVien", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiTaiKhoanEntity", b =>
                {
                    b.Property<string>("IdLoaiTaiKhoan")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdLoaiTaiKhoan");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoaiTaiKhoan")
                        .HasName("PK_LoaiTaiKhoan");

                    b.ToTable("LoaiTaiKhoan", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.LoaiTourEntity", b =>
                {
                    b.Property<string>("IdLoaiTour")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdLoaiTour");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoaiTour")
                        .HasName("PK_LoaiTour");

                    b.ToTable("LoaiTour", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.NhanVienEntity", b =>
                {
                    b.Property<string>("IdNhanVien")
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
                        .HasDefaultValue(new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(1452));

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

                    b.HasKey("IdNhanVien")
                        .HasName("PK_NhanVien");

                    b.HasIndex("maLoaiNhanVien");

                    b.HasIndex("maTaiKhoan")
                        .IsUnique()
                        .HasFilter("[maTaiKhoan] IS NOT NULL");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.NhanXetEntity", b =>
                {
                    b.Property<string>("IdNhanXet")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdNhanXet");

                    b.Property<string>("IdNguoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdTour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("danhGia")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayDang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(6687));

                    b.Property<string>("noiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNhanXet");

                    b.HasIndex("IdNguoiDung");

                    b.HasIndex("IdTour");

                    b.ToTable("NhanXet", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.SanBayEntity", b =>
                {
                    b.Property<string>("IdSanBay")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdSanBay");

                    b.Property<string>("tenSanBay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSanBay")
                        .HasName("PK_SanBay");

                    b.ToTable("SanBay", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TaiKhoanEntity", b =>
                {
                    b.Property<string>("IdTaiKhoan")
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
                        .HasDefaultValue(new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(4285));

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("trangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("IdTaiKhoan")
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
                    b.Property<string>("IdThanhVien")
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

                    b.HasKey("IdThanhVien")
                        .HasName("PK_ThanhVien");

                    b.HasIndex("maDatTour");

                    b.ToTable("ThanhVien", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", b =>
                {
                    b.Property<string>("IdTour")
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
                        .HasDefaultValue(new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(6093));

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

                    b.HasKey("IdTour")
                        .HasName("PK_Tour");

                    b.HasIndex("maChuyenBay");

                    b.HasIndex("maKhachSan");

                    b.HasIndex("maLoaiTour");

                    b.HasIndex("nguoiLap");

                    b.HasIndex("tenTour")
                        .IsUnique();

                    b.ToTable("Tour", (string)null);
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TraLoiHoiDapEntity", b =>
                {
                    b.Property<string>("IdTraLoiHoiDap")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdTraLoiHoiDap");

                    b.Property<string>("IdHoiDap")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngayTraLoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 23, 10, 17, 8, 407, DateTimeKind.Local).AddTicks(7671));

                    b.Property<string>("noiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTraLoiHoiDap");

                    b.HasIndex("IdHoiDap");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("TraLoiHoiDap", (string)null);
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

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.HoiDapEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", "KhachHang")
                        .WithMany("HoiDaps")
                        .HasForeignKey("IdNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", "Tour")
                        .WithMany()
                        .HasForeignKey("IdTour")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.NhanXetEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", "KhachHang")
                        .WithMany("NhanXets")
                        .HasForeignKey("IdNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.TourEntity", "Tour")
                        .WithMany("danhSachNhanXet")
                        .HasForeignKey("IdTour")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("Tour");
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

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.TraLoiHoiDapEntity", b =>
                {
                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.HoiDapEntity", "HoiDap")
                        .WithMany("danhSachCauTraLoi")
                        .HasForeignKey("IdHoiDap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", "KhachHang")
                        .WithMany("TraLoiHoiDaps")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("HoiDap");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.DatTourEntity", b =>
                {
                    b.Navigation("ThanhViens");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.HoiDapEntity", b =>
                {
                    b.Navigation("danhSachCauTraLoi");
                });

            modelBuilder.Entity("Nhom6_QuanLyTourDuLich_BackEnd.Data.KhachHangEntity", b =>
                {
                    b.Navigation("HoiDaps");

                    b.Navigation("NhanXets");

                    b.Navigation("Tours");

                    b.Navigation("TraLoiHoiDaps");
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

                    b.Navigation("danhSachNhanXet");
                });
#pragma warning restore 612, 618
        }
    }
}
