using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class NhanVienModel
    {
        public string Id { get; set; }
        public string? maTaiKhoan { get; set; }
        public string maLoaiNhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public bool gioiTinh { get; set; }
        public string soDienThoai { get; set; }
        public DateTime ngaySinh { get; set; }
        public DateTime ngayVaoLam { get; set; }
        public string? canCuocConDan { get; set; }
        public string diaChi { get; set; }
        public NhanVienModel() { }

        public NhanVienModel(string id, string? maTaiKhoan, string maLoaiNhanVien, string tenNhanVien, bool gioiTinh,
            string soDienThoai, DateTime ngaySinh, DateTime ngayVaoLam, string? canCuocConDan, string diaChi)
        {
            Id = id;
            this.maTaiKhoan = maTaiKhoan;
            this.maLoaiNhanVien = maLoaiNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
            this.ngayVaoLam = ngayVaoLam;
            this.canCuocConDan = canCuocConDan;
            this.diaChi= diaChi;
        }
    }
}
