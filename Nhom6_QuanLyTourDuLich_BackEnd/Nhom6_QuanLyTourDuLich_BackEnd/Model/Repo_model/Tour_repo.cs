using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class Tour_repo
    {
        public string tenTour { get; set; }
        public string moTa { get; set; }
        public string anhBia { get; set; }
        public double chiPhi { get; set; }
        public DateTime ngayLap { get; set; }
        public string nguoiLap { get; set; }
        public string maLoaiTour { get; set; }
        public string? maChuyenBay { get; set; }
        public string maKhachSan { get; set; }
        public string phuongTienDiChuyen { get; set; }
        public bool trangThai { get; set; }

        public Tour_repo() { }

        public Tour_repo(string tenTour, string moTa, string anhBia, double chiPhi, DateTime ngayLap,
            string nguoiLap, string maLoaiTour, string? maChuyenBay, string maKhachSan, string phuongTienDiChuyen, bool trangThai)
        {
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
