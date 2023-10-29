using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper
{
    public class AutoMapperApp:Profile
    {
        public AutoMapperApp()
        {
            CreateMap<LoaiTourEntity, LoaiTourModel>().ReverseMap();
            CreateMap<TourEntity, TourModel>().ReverseMap();
            CreateMap<ChiTietChuongTrinhTourEntity, ChiTietChuongTrinhTourModel>().ReverseMap();
            CreateMap<ChuyenBayEntity, ChuyenBayModel>().ReverseMap();
            CreateMap<DanhMucHinhEntity, DanhMucHinhModel>().ReverseMap();
            CreateMap<DatTourEntity, DatTourModel>().ReverseMap();
            CreateMap<KhachHangEntity, KhachHangModel>().ReverseMap();
            CreateMap<KhachSanEntity, KhachSanModel>().ReverseMap();
            CreateMap<LoaiNhanVienEntity, LoaiNhanVienModel>().ReverseMap();
            CreateMap<LoaiTaiKhoanEntity, LoaiTaiKhoanModel>().ReverseMap();
            CreateMap<NhanVienEntity, NhanVienModel>().ReverseMap();
            CreateMap<SanBayEntity, SanBayModel>().ReverseMap();
            CreateMap<TaiKhoanEntity, TaiKhoanModel>().ReverseMap();
            CreateMap<ThanhVienEntity, ThanhVienModel>().ReverseMap();
            CreateMap<NhanXetEntity, NhanXetModel>().ReverseMap();
            CreateMap<HoiDapEntity, HoiDapModel>().ReverseMap();
            CreateMap<TraLoiHoiDapEntity, TraLoiHoiDapModel>().ReverseMap();

            CreateMap<DatTourEntity, ThanhToanModel>().ReverseMap();

            //==============
            CreateMap<LoaiTourEntity, LoaiTour_repo>().ReverseMap();
            CreateMap<TourEntity, Tour_repo>().ReverseMap();
            CreateMap<ChiTietChuongTrinhTourEntity, ChiTietChuongTrinhTour_repo>().ReverseMap();
            CreateMap<ChuyenBayEntity, ChuyenBay_repo>().ReverseMap();
            CreateMap<DanhMucHinhEntity, DanhMucHinh_repo>().ReverseMap();
            CreateMap<DatTourEntity, DatTour_repo>().ReverseMap();
            CreateMap<KhachHangEntity, KhachHang_repo>().ReverseMap();
            CreateMap<KhachSanEntity, KhachSan_repo>().ReverseMap();
            CreateMap<LoaiNhanVienEntity, LoaiNhanVien_repo>().ReverseMap();
            CreateMap<LoaiTaiKhoanEntity, LoaiTaiKhoan_repo>().ReverseMap();
            CreateMap<NhanVienEntity, NhanVien_repo>().ReverseMap();
            CreateMap<SanBayEntity, SanBay_repo>().ReverseMap();
            CreateMap<TaiKhoanEntity, TaiKhoan_repo>().ReverseMap();
            CreateMap<ThanhVienEntity, ThanhVien_repo>().ReverseMap();
            CreateMap<NhanXetEntity, NhanXet_repo>().ReverseMap();
            CreateMap<HoiDapEntity, HoiDap_repo>().ReverseMap();
            CreateMap<TraLoiHoiDapEntity, TraLoiHoiDap_repo>().ReverseMap();
        }
    }
}
