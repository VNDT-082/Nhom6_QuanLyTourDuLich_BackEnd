using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class DatTour_repo
    {
        public string maKhach { get; set; }
        public string? maHuongDanVien { get; set; }
        public string maTour { get; set; }
        public int soLuong { get; set; }
        public DateTime ngayDat { get; set; }
        public bool trangThai { get; set; }
        public virtual ICollection<ThanhVien_repo>? ThanhViens { get; set; }
        public DatTour_repo() { }

        public DatTour_repo(string maKhach, string? maHuongDanVien, string maTour, int soLuong,
            DateTime ngayDat, bool trangThai)
        {
            this.maKhach = maKhach;
            this.maHuongDanVien = maHuongDanVien;
            this.maTour = maTour;
            this.soLuong = soLuong;
            this.ngayDat = ngayDat;
            this.trangThai = trangThai;
        }
    }
}
