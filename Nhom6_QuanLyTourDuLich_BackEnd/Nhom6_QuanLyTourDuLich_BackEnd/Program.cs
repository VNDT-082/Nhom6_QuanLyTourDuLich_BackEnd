using Microsoft.EntityFrameworkCore;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository;
using Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository;
using Nhom6_QuanLyTourDuLich_BackEnd.Services;
using Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<QuanLyTourDuLich_DBContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDB"));
});

builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddScoped<IChiTietChuongTrinhTourRepository, ChiTietChuongTrinhTourRepository>();
builder.Services.AddScoped<IChuyenBayRepository, ChuyenBayRepository>();
builder.Services.AddScoped<IDanhMucHinhRepository, DanhMucHinhRepository>();
builder.Services.AddScoped<IDatTourRepository, DatTourRepository>();
builder.Services.AddScoped<IKhachHangRepository, KhachHangRepository>();
builder.Services.AddScoped<IKhachSanRepository, KhachSanRepository>();
builder.Services.AddScoped<ILoaiNhanVienRepository, LoaiNhanVienRepository>();
builder.Services.AddScoped<ILoaiTaiKhoanRepository, LoaiTaiKhoanRepository>();
builder.Services.AddScoped<ILoaiTourRepository, LoaiTourRepository>();
builder.Services.AddScoped<INhanVienRepository, NhanVienRepository>();
builder.Services.AddScoped<ISanBayRepository, SanBayRepository>();
builder.Services.AddScoped<ITaiKhoanRepository, TaiKhoanRepository>();
builder.Services.AddScoped<IThanhVienRepository, ThanhVienRepository>();
builder.Services.AddScoped<ITourRepository, TourRepository>();


builder.Services.AddScoped<IChiTietChuongTrinhTourService, ChiTietChuongTrinhTourService>();
builder.Services.AddScoped<IChuyenBayService, ChuyenBayService>();
builder.Services.AddScoped<IDanhMucHinhService, DanhMucHinhService>();
builder.Services.AddScoped<IDatTourService, DatTourService>();
builder.Services.AddScoped<IKhachHangService, KhachHangService>();
builder.Services.AddScoped<IKhachSanService, KhachSanService>();
builder.Services.AddScoped<ILoaiNhanVienService, LoaiNhanVienService>();
builder.Services.AddScoped<ILoaiTaiKhoanService, LoaiTaiKhoanService>();
builder.Services.AddScoped<ILoaiTourServices, LoaiTourService>();
builder.Services.AddScoped<INhanVienService, NhanVienService>();
builder.Services.AddScoped<ISanBayService, SanBayService>();
builder.Services.AddScoped<ITaiKhoanService, TaiKhoanService>();
builder.Services.AddScoped<IThanhVienService, ThanhVienService>();
builder.Services.AddScoped<ITourService, TourService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(builder => { builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });

app.MapControllers();

app.Run();
