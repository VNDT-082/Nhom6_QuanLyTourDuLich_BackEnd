using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class ChuyenBayModel
    {
        public string IdChuyenBay { get; set; }
        public string hangBay { get; set; }
        public DateTime gioKhoiHanh { get; set; }
        public string? noiKhoiHanh { get; set; }
        public DateTime gioDen { get; set; }
        public string? noiDen { get; set; }
        public bool khuHoi { get; set; }
        public string mayBay { get; set; }
        public bool trangThai { get; set; }
        public string? maChuyenVe { get; set; }
        public ChuyenBayModel() { }

        public ChuyenBayModel(string IdChuyenBay, string hangBay, DateTime gioKhoiHanh, string? noiKhoiHanh, DateTime gioDen, string? noiDen,
            bool khuHoi, string mayBay, bool trangThai, string? maChuyenVe)
        {
            this.IdChuyenBay = IdChuyenBay;
            this.hangBay = hangBay;
            this.gioKhoiHanh = gioKhoiHanh;
            this.noiKhoiHanh = noiKhoiHanh;
            this.gioDen = gioDen;
            this.noiDen = noiDen;
            this.khuHoi = khuHoi;
            this.mayBay = mayBay;
            this.trangThai = trangThai;
            this.maChuyenVe = maChuyenVe;
        }
    }
}
