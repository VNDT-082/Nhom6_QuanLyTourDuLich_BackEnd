namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class ChiTietChuongTrinhTourModel
    {
        public string IdChiTietChuongTrinhTour { get; set; }
        public string maTour { get; set; }
        public string ngayThu { get; set; }
        public string buaAn { get; set; }
        public string diemKhoiHanh { get; set; }
        public string diemDen { get; set; }
        public string tieuDe { get; set; }
        public string moTa { get; set; }
        public string hinhAnh { get; set; }
        public string maKhachSan { get; set; }
        public string phuongTien { get; set; }
        public ChiTietChuongTrinhTourModel() { }
        public ChiTietChuongTrinhTourModel( string IdChiTietChuongTrinhTour,string maTour, string ngayThu, string buaAn, string diemKhoiHanh
            , string diemDen, string tieuDe, string moTa, string hinhAnh, string maKhachSan, string phuongTien)
        {
            this.IdChiTietChuongTrinhTour = IdChiTietChuongTrinhTour;
            this.maTour = maTour;
            this.ngayThu = ngayThu;
            this.buaAn = buaAn;
            this.diemKhoiHanh = diemKhoiHanh;
            this.diemDen = diemDen;
            this.tieuDe = tieuDe;
            this.moTa = moTa;
            this.hinhAnh = hinhAnh;
            this.maKhachSan = maKhachSan;
            this.phuongTien = phuongTien;
        }

        public ChiTietChuongTrinhTourModel(string IdChiTietChuongTrinhTour,string maTour, string ngayThu, string buaAn, string diemKhoiHanh
            , string diemDen, string tieuDe, string moTa, string hinhAnh, string phuongTien)
        {
            this.IdChiTietChuongTrinhTour = IdChiTietChuongTrinhTour;
            this.maTour = maTour;
            this.ngayThu = ngayThu;
            this.buaAn = buaAn;
            this.diemKhoiHanh = diemKhoiHanh;
            this.diemDen = diemDen;
            this.tieuDe = tieuDe;
            this.moTa = moTa;
            this.hinhAnh = hinhAnh;
            this.phuongTien = phuongTien;
        }
    }
}
