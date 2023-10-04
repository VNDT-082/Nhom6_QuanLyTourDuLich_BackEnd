using AutoMapper;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.AutoMapper
{
    public class AutoMapperApp:Profile
    {
        public AutoMapperApp()
        {
            CreateMap<LoaiTourEntity, LoaiTourModel>().ReverseMap();
            CreateMap<TourEntity, TourModel>().ReverseMap();
        }
    }
}
