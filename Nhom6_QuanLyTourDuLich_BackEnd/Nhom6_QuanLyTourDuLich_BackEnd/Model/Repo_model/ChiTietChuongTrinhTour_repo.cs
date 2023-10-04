using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class ChiTietChuongTrinhTour_repo
    {
        public string maTour { get; set; }
        public DateTime thoiGianBatDau { get; set; }
        public DateTime thoiGianKetThuc { get; set; }
        public string diemKhoiHanh { get; set; }
        public string diemDen { get; set; }
        public string tieuDe { get; set; }
        public string moTa { get; set; }
        public string hinhAnh { get; set; }
        public string maKhachSan { get; set; }
        public string phuongTien { get; set; }
        public ChiTietChuongTrinhTour_repo() { }
        public ChiTietChuongTrinhTour_repo(string maTour, DateTime thoiGianBatDau,DateTime thoiGianKetThuc, string diemKhoiHanh
            ,string diemDen, string tieuDe, string moTa, string hinhAnh, string maKhachSan, string phuongTien) 
        {
            this.maTour = maTour;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.diemKhoiHanh = diemKhoiHanh;
            this.diemDen = diemDen;
            this.tieuDe = tieuDe;
            this.moTa = moTa;
            this.hinhAnh = hinhAnh;
            this.maKhachSan = maKhachSan;
            this.phuongTien = phuongTien;
        }

        public ChiTietChuongTrinhTour_repo(string maTour, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string diemKhoiHanh
            , string diemDen, string tieuDe, string moTa, string hinhAnh, string phuongTien)
        {
            this.maTour = maTour;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.diemKhoiHanh = diemKhoiHanh;
            this.diemDen = diemDen;
            this.tieuDe = tieuDe;
            this.moTa = moTa;
            this.hinhAnh = hinhAnh;
            this.phuongTien = phuongTien;
        }

    }
}
