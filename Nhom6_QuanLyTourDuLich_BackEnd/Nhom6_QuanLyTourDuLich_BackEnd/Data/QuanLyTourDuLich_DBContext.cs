using Microsoft.EntityFrameworkCore;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    public class QuanLyTourDuLich_DBContext:DbContext
    {
        public QuanLyTourDuLich_DBContext() { }
        public QuanLyTourDuLich_DBContext(DbContextOptions<QuanLyTourDuLich_DBContext> dbContextOptions)
        : base(dbContextOptions) { }

        public DbSet<TinhEntity> Tinhs { get; set; }
        public DbSet<HuyenEntity> Huyens { get; set; }
        public DbSet<XaEntity> Xas { get; set; }

        public DbSet<ChiTietChuongTrinhTourEntity> ChiTietChuongTrinhTours { get; set; }
        public DbSet<ChuyenBayEntity> ChuyenBays { get; set; }
        public DbSet<DanhMucHinhEntity> DanhMucHinhs { get; set; }
        public DbSet<DatTourEntity> DatTours { get; set; }
        public DbSet<KhachHangEntity> KhachHangs { get; set; }
        public DbSet<KhachSanEntity> KhachSans { get; set; }
        public DbSet<LoaiNhanVienEntity> LoaiNhanViens { get; set; }
        public DbSet<LoaiTaiKhoanEntity> LoaiTaiKhoans { get; set; }
        public DbSet<LoaiTourEntity> LoaiTours { get; set; }
        public DbSet<NhanVienEntity> NhanViens { get; set; }
        public DbSet<SanBayEntity> SanBays { get; set; }
        public DbSet<TaiKhoanEntity> TaiKhoans { get; set; }
        public DbSet<ThanhVienEntity> ThanhViens { get; set; }
        public DbSet<TourEntity> Tours { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Tinh
            modelBuilder.Entity<TinhEntity>(entity =>
            {
                entity.ToTable("Tinh");
                entity.HasIndex(i => i.tenTinh).IsUnique();

            });
            //Huyen
            modelBuilder.Entity<HuyenEntity>(entity =>
            {
                entity.ToTable("Huyen");
                entity.HasIndex(i => i.tenHuyen).IsUnique();
            });
            //Xa
            modelBuilder.Entity<XaEntity>(entity =>
            {
                entity.ToTable("Xa");
                entity.HasIndex(i => i.tenXa).IsUnique();
            });
            //ChiTietChuongTrinhTour
            modelBuilder.Entity<ChiTietChuongTrinhTourEntity>(entity =>
            {
                entity.ToTable("ChiTietChuongTrinhTour");
                entity.Property(i => i.hinhAnh).HasDefaultValue("ImageDefault.png");
                entity.HasIndex(i => i.tieuDe).IsUnique();
            });
            //ChuyenBay
            modelBuilder.Entity<ChuyenBayEntity>(entity =>
            {
                entity.ToTable("ChuyenBay");
                entity.Property(i => i.trangThai).HasDefaultValue(true);
            });
            //DanhMucHinh
            modelBuilder.Entity<DanhMucHinhEntity>(entity =>
            {
                entity.ToTable("DanhMucHinh");
                entity.Property(i => i.fileName).HasDefaultValue("ImageDefault.png");
            });
            //DatTour
            modelBuilder.Entity<DatTourEntity>(entity =>
            {
                entity.ToTable("DatTour");
                entity.Property(i => i.trangThai).HasDefaultValue(true);
                entity.Property(i => i.ngayDat).HasDefaultValue(DateTime.Now);//.ToString("dd/MM/yyyy HH:mm:ss")
            });
            //KhachHang
            modelBuilder.Entity<KhachHangEntity>(entity =>
            {
                entity.HasIndex(i => i.maTaiKhoan).IsUnique();
            });

            //KhachSan
            modelBuilder.Entity<KhachSanEntity>(entity =>
            {
                entity.ToTable("KhachSan");
                entity.Property(i => i.hangSao).HasDefaultValue("0");
            });
            //LoaiNhanVien
            modelBuilder.Entity<LoaiNhanVienEntity>(entity =>
            {
                entity.ToTable("LoaiNhanVien");
            });
            //LoaiTaiKhoan
            modelBuilder.Entity<LoaiTaiKhoanEntity>(entity =>
            {
                entity.ToTable("LoaiTaiKhoan");
            });
            //LoaiTour
            modelBuilder.Entity<LoaiTourEntity>(entity =>
            {
                entity.ToTable("LoaiTour");
            });
            //NhanVien
            modelBuilder.Entity<NhanVienEntity>(entity =>
            {
                entity.ToTable("NhanVien");
                entity.Property(i => i.maLoaiNhanVien).HasDefaultValue("0");
                entity.Property(i => i.ngayVaoLam).HasDefaultValue(DateTime.Now);//.ToString("dd/MM/yyyy HH:mm:ss")
                entity.HasIndex(i => i.maTaiKhoan).IsUnique();
            });

            //SanBay
            modelBuilder.Entity<SanBayEntity>(entity =>
            {
                entity.ToTable("SanBay");
            });
            //TaiKhoan
            modelBuilder.Entity<TaiKhoanEntity>(entity =>
            {
                entity.ToTable("TaiKhoan");
                entity.HasIndex(i => i.soDienThoai).IsUnique();
                entity.HasIndex(i => i.email).IsUnique();
                entity.Property(i => i.trangThai).HasDefaultValue(0);
                entity.Property(i => i.ngayLap).HasDefaultValue(DateTime.Now);//.ToString("dd/MM/yyyy HH:mm:ss")
            });
            //ThanhVien
            modelBuilder.Entity<ThanhVienEntity>(entity =>
            {
                entity.ToTable("ThanhVien");
            });
            //Tour
            modelBuilder.Entity<TourEntity>(entity =>
            {
                entity.ToTable("Tour");
                entity.HasIndex(i => i.tenTour).IsUnique();
                entity.Property(i => i.trangThai).HasDefaultValue(true);
                entity.Property(i => i.ngayLap).HasDefaultValue(DateTime.Now);//.ToString("dd/MM/yyyy HH:mm:ss")
            });
        }
        
    }
}
