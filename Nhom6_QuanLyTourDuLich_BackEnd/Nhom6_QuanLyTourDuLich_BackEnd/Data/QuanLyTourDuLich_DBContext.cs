using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    public class QuanLyTourDuLich_DBContext:DbContext
    {
        public QuanLyTourDuLich_DBContext() { }
        public QuanLyTourDuLich_DBContext(DbContextOptions<QuanLyTourDuLich_DBContext> dbContextOptions)
        : base(dbContextOptions) { }

        public DbSet<ChiTietChuongTrinhTourEntity> ChiTietChuongTrinhTours { get; set; }
        public DbSet<ChuyenBayEntity> ChuyenBays { get; set; }
        public DbSet<DanhMucHinhEntity> DanhMucHinhs { get; set; }
        public DbSet<DatTourEntity> DatTours { get; set; }
        public DbSet<HoiDapEntity> HoiDaps { get; set; }
        public DbSet<KhachHangEntity> KhachHangs { get; set; }
        public DbSet<KhachSanEntity> KhachSans { get; set; }
        public DbSet<LoaiNhanVienEntity> LoaiNhanViens { get; set; }
        public DbSet<LoaiTaiKhoanEntity> LoaiTaiKhoans { get; set; }
        public DbSet<LoaiTourEntity> LoaiTours { get; set; }
        public DbSet<NhanVienEntity> NhanViens { get; set; }
        public DbSet<NhanXetEntity> NhanXets { get; set; }
        public DbSet<SanBayEntity> SanBays { get; set; }
        public DbSet<TaiKhoanEntity> TaiKhoans { get; set; }
        public DbSet<ThanhVienEntity> ThanhViens { get; set; }
        public DbSet<TourEntity> Tours { get; set; }
        public DbSet<TraLoiHoiDapEntity> TraLoiHoiDaps { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //ChiTietChuongTrinhTour
            modelBuilder.Entity<ChiTietChuongTrinhTourEntity>(entity =>
            {
                entity.ToTable("ChiTietChuongTrinhTour");
                entity.Property(i => i.IdChiTietChuongTrinhTour).HasColumnName("IdChiTietChuongTrinhTour");
                entity.Property(i => i.hinhAnh).HasDefaultValue("ImageDefault.png");
                entity.HasKey(i => i.IdChiTietChuongTrinhTour).HasName("PK_ChiTietChuongTrinhTour");
            });
            //ChuyenBay
            modelBuilder.Entity<ChuyenBayEntity>(entity =>
            {
                entity.ToTable("ChuyenBay");
                entity.Property(i => i.IdChuyenBay).HasColumnName("IdChuyenBay");
                entity.Property(i => i.trangThai).HasDefaultValue(true);
                entity.HasKey(i => i.IdChuyenBay).HasName("PK_ChuyenBay");
            });
            //DanhMucHinh
            modelBuilder.Entity<DanhMucHinhEntity>(entity =>
            {
                entity.ToTable("DanhMucHinh");
                entity.Property(i => i.IdDanhMucHinh).HasColumnName("IdDanhMucHinh");
                entity.Property(i => i.fileName).HasDefaultValue("ImageDefault.png");
                entity.HasKey(i => i.IdDanhMucHinh).HasName("PK_DanhMucHinh");
            });
            //DatTour
            modelBuilder.Entity<DatTourEntity>(entity =>
            {
                entity.ToTable("DatTour");
                entity.Property(i => i.IdDatTour).HasColumnName("IdDatTour");
                //entity.Property(i => i.trangThai).HasDefaultValue(true);
                entity.Property(i => i.ngayDat).HasDefaultValue(DateTime.Now);//.ToString("dd/MM/yyyy HH:mm:ss")
                entity.HasKey(i => i.IdDatTour).HasName("PK_DatTour");
            });
            //KhachHang
            modelBuilder.Entity<KhachHangEntity>(entity =>
            {
                entity.HasIndex(i => i.maTaiKhoan).IsUnique();
                entity.Property(i => i.IdKhachHang).HasColumnName("IdKhachHang");
                entity.HasKey(i => i.IdKhachHang).HasName("PK_KhachHang");
            });
            

            //KhachSan
            modelBuilder.Entity<KhachSanEntity>(entity =>
            {
                entity.ToTable("KhachSan");
                entity.Property(i => i.IdKhachSan).HasColumnName("IdKhachSan");
                entity.Property(i => i.hangSao).HasDefaultValue("0");
                entity.HasKey(i => i.IdKhachSan).HasName("PK_KhachSan");
            });
            //LoaiNhanVien
            modelBuilder.Entity<LoaiNhanVienEntity>(entity =>
            {
                entity.ToTable("LoaiNhanVien");
                entity.Property(i => i.IdLoaiNhanVien).HasColumnName("IdLoaiNhanVien");
                entity.HasKey(i => i.IdLoaiNhanVien).HasName("PK_LoaiNhanVien");
            });
            //LoaiTaiKhoan
            modelBuilder.Entity<LoaiTaiKhoanEntity>(entity =>
            {
                entity.ToTable("LoaiTaiKhoan");
                entity.Property(i => i.IdLoaiTaiKhoan).HasColumnName("IdLoaiTaiKhoan");
                entity.HasKey(i => i.IdLoaiTaiKhoan).HasName("PK_LoaiTaiKhoan");
            });
            //LoaiTour
            modelBuilder.Entity<LoaiTourEntity>(entity =>
            {
                entity.ToTable("LoaiTour");
                entity.Property(i => i.IdLoaiTour).HasColumnName("IdLoaiTour");
                entity.HasKey(i => i.IdLoaiTour).HasName("PK_LoaiTour");
            });
            //NhanVien
            modelBuilder.Entity<NhanVienEntity>(entity =>
            {
                entity.ToTable("NhanVien");
                entity.Property(i => i.IdNhanVien).HasColumnName("IdNhanVien");
                entity.Property(i => i.maLoaiNhanVien).HasDefaultValue("0");
                entity.Property(i => i.trangThai).HasDefaultValue(true);
                entity.Property(i => i.ngayVaoLam).HasDefaultValue(DateTime.Now);//.ToString("dd/MM/yyyy HH:mm:ss")
                entity.HasIndex(i => i.maTaiKhoan).IsUnique();
                entity.HasKey(i => i.IdNhanVien).HasName("PK_NhanVien");
            });

            //SanBay
            modelBuilder.Entity<SanBayEntity>(entity =>
            {
                entity.ToTable("SanBay");
                entity.Property(i => i.IdSanBay).HasColumnName("IdSanBay");
                entity.HasKey(i => i.IdSanBay).HasName("PK_SanBay");
            });
            //TaiKhoan
            modelBuilder.Entity<TaiKhoanEntity>(entity =>
            {
                entity.ToTable("TaiKhoan");
                entity.Property(i => i.IdTaiKhoan).HasColumnName("IdTaiKhoan");
                entity.HasIndex(i => i.soDienThoai).IsUnique();
                entity.HasIndex(i => i.email).IsUnique();
                entity.Property(i => i.trangThai).HasDefaultValue(0);
                entity.Property(i => i.ngayLap).HasDefaultValue(DateTime.Now);//.ToString("dd/MM/yyyy HH:mm:ss")
                entity.HasKey(i => i.IdTaiKhoan).HasName("PK_TaiKhoan");
                
            });
            //ThanhVien
            modelBuilder.Entity<ThanhVienEntity>(entity =>
            {
                entity.ToTable("ThanhVien");
                entity.Property(i => i.IdThanhVien).HasColumnName("IdThanhVien");
                entity.HasKey(i => i.IdThanhVien).HasName("PK_ThanhVien");
                entity.Property(i => i.IdThanhVien).HasColumnName("IdThanhVien");
            });
            //Tour
            modelBuilder.Entity<TourEntity>(entity =>
            {
                entity.ToTable("Tour");
                entity.Property(i => i.IdTour).HasColumnName("IdTour");
                entity.HasIndex(i => i.tenTour).IsUnique();
                entity.Property(i => i.trangThai).HasDefaultValue(true);
                entity.Property(i => i.ngayLap).HasDefaultValue(DateTime.Now);//.ToString("dd/MM/yyyy HH:mm:ss")
                entity.HasKey(i => i.IdTour).HasName("PK_Tour");
               
            });

            //============================NHANXET DANH GIA TOUR===================
            modelBuilder.Entity<NhanXetEntity>(entity =>
            {
                entity.ToTable("NhanXet");
                entity.Property(i => i.IdNhanXet).HasColumnName("IdNhanXet");
                entity.Property(i => i.ngayDang).HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<HoiDapEntity>(entity =>
            {
                entity.ToTable("HoiDap");
                entity.Property(i => i.IdHoiDap).HasColumnName("IdHoiDap");
                entity.Property(i => i.ngayDang).HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<TraLoiHoiDapEntity>(entity =>
            {
                entity.ToTable("TraLoiHoiDap");
                entity.Property(i => i.IdTraLoiHoiDap).HasColumnName("IdTraLoiHoiDap");
                entity.Property(i => i.ngayTraLoi).HasDefaultValue(DateTime.Now);
            });
            modelBuilder
                   .Entity<TraLoiHoiDapEntity>()
                   .HasOne(e => e.KhachHang).WithMany(e => e.TraLoiHoiDaps).OnDelete(DeleteBehavior.NoAction);
        }
        
    }
}
