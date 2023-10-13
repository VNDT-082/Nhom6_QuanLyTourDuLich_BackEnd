using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class DatTourModel
    {
        public string IdDatTour { get; set; }
        public string maKhach { get; set; }
        public string? maHuongDanVien { get; set; }
        public string maTour { get; set; }
        public int soLuong { get; set; }
        public DateTime ngayDat { get; set; }
        public bool trangThai { get; set; }
        public virtual ICollection<ThanhVienModel>? ThanhViens { get; set; }
        public DatTourModel() { }

        public DatTourModel(string IdDatTour, string maKhach, string? maHuongDanVien, string maTour, int soLuong,
            DateTime ngayDat, bool trangThai)
        {
            this.IdDatTour = IdDatTour;
            this.maKhach = maKhach;
            this.maHuongDanVien = maHuongDanVien;
            this.maTour = maTour;
            this.soLuong = soLuong;
            this.ngayDat = ngayDat;
            this.trangThai = trangThai;
        }
    }
}
