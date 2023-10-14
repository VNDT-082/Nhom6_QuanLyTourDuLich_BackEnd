using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class KhachHangModel
    {
        public string IdKhachHang { get; set; }
        public string hoTen { get; set; }
        public bool gioiTinh { get; set; }

        public string? diaChi { get; set; }
        public string email { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string soDienThoai { get; set; }
        public string maTaiKhoan { get; set; }
        public virtual ICollection<DatTourModel>? Tours { get; set; }
        //public virtual TaiKhoanModel taiKhoan { get; set; }
        public KhachHangModel() { }

        public KhachHangModel(string IdKhachHang, string hoTen, bool gioiTinh, string? diaChi, string email, DateTime? ngaySinh, 
            string soDienThoai, string maTaiKhoan)
        {
            this.IdKhachHang = IdKhachHang;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.email = email;
            this.ngaySinh = ngaySinh;
            this.soDienThoai = soDienThoai;
            this.maTaiKhoan = maTaiKhoan;
        }
    }
}
