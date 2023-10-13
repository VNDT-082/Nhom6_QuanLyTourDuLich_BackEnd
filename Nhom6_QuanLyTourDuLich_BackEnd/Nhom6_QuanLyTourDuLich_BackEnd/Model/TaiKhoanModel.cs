using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class TaiKhoanModel
    {
        public string IdTaiKhoan { get; set; }
        public string maLoai { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public string matKhau { get; set; }
        public bool trangThai { get; set; }
        public DateTime? ngayLap { get; set; }

        public TaiKhoanModel() { }
        public TaiKhoanModel(string IdTaiKhoan, string maLoai, string soDienThoai, string email, string matKhau, bool trangThai, DateTime? ngayLap)
        {
            this.IdTaiKhoan = IdTaiKhoan;
            this.maLoai = maLoai;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.matKhau = matKhau;
            this.trangThai = trangThai;
            this.ngayLap = ngayLap;
        }


    }
}
