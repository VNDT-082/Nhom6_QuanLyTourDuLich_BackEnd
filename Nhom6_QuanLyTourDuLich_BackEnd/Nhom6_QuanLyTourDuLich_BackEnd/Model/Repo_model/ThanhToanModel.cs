namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class ThanhToanModel
    {
        public string IdDatTour { get; set; }
        public string maKhach { get; set; }
        public string? maHuongDanVien { get; set; }
        public string maTour { get; set; }
        public int soLuong { get; set; }
        public DateTime ngayDat { get; set; }
        public bool trangThai { get; set; }
        public virtual TourModel Tour { get; set; }
        public virtual KhachHangModel KhachHang { get; set; }
        public virtual ICollection<ThanhVienModel>? ThanhViens { get; set; }
        public ThanhToanModel() { }

        public ThanhToanModel(string IdDatTour, string maKhach, string? maHuongDanVien, string maTour, int soLuong,
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
