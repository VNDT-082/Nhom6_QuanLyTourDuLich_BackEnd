namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class ChiTietChuongTrinhTourModel
    {
        public string Id { get; set; }
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
        public ChiTietChuongTrinhTourModel() { }
        public ChiTietChuongTrinhTourModel( string Id,string maTour, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string diemKhoiHanh
            , string diemDen, string tieuDe, string moTa, string hinhAnh, string maKhachSan, string phuongTien)
        {
            this.Id = Id;
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

        public ChiTietChuongTrinhTourModel(string Id,string maTour, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string diemKhoiHanh
            , string diemDen, string tieuDe, string moTa, string hinhAnh, string phuongTien)
        {
            this.Id = Id;
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
