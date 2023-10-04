using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class KhachHangModel
    {
        public string Id { get; set; }
        public string hoTen { get; set; }
        public bool gioiTinh { get; set; }

        public string? diaChi { get; set; }
        public string? id_Xa { get; set; }
        public string email { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string soDienThoai { get; set; }
        public string maTaiKhoan { get; set; }
        public virtual ICollection<DatTourEntity>? Tours { get; set; }

        public KhachHangModel() { }

        public KhachHangModel(string Id, string hoTen, bool gioiTinh, string? diaChi, string? id_Xa, string email, DateTime? ngaySinh, 
            string soDienThoai, string maTaiKhoan)
        {
            this.Id = Id;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.id_Xa = id_Xa;
            this.email = email;
            this.ngaySinh = ngaySinh;
            this.soDienThoai = soDienThoai;
            this.maTaiKhoan = maTaiKhoan;
        }
    }
}
