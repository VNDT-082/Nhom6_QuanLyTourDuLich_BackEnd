using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class TourModel
    {
        public string Id { get; set; }
        public string tenTour { get; set; }
        public string? moTa { get; set; }
        public string anhBia { get; set; }
        public double chiPhi { get; set; }
        public DateTime? ngayLap { get; set; }
        public string? nguoiLap { get; set; }
        public string maLoaiTour { get; set; }
        public string? maChuyenBay { get; set; }
        public string? maKhachSan { get; set; }
        public string? phuongTienDiChuyen { get; set; }
        public bool? trangThai { get; set; }
        public virtual ICollection<DanhMucHinhModel>? DanhMucHinhs { get; set; }

        public TourModel() { }

        public TourModel(string id, string tenTour, string moTa, string anhBia, double chiPhi, DateTime ngayLap, 
            string nguoiLap, string maLoaiTour, string? maChuyenBay, string maKhachSan, string phuongTienDiChuyen, bool trangThai)
        {
            this.Id = id;
            this.tenTour = tenTour;
            this.moTa = moTa;
            this.anhBia = anhBia;
            this.chiPhi = chiPhi;
            this.ngayLap = ngayLap;
            this.nguoiLap = nguoiLap;
            this.maLoaiTour = maLoaiTour;
            this.maChuyenBay = maChuyenBay;
            this.maKhachSan = maKhachSan;
            this.phuongTienDiChuyen = phuongTienDiChuyen;
            this.trangThai = trangThai;
        }
    }
}
