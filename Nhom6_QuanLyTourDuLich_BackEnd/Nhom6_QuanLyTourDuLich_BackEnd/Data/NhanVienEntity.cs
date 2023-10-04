using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("NhanVien")]
    public class NhanVienEntity:Entity
    {
        [ForeignKey("TaiKhoan")]
        public string? maTaiKhoan { get; set; }

        [ForeignKey("LoaiNhanVien")]
        public string? maLoaiNhanVien { get; set; }

        [Required]
        public string tenNhanVien { get; set; }
        public bool gioiTinh { get; set; }

        [Required]
        public string soDienThoai { get; set; }

        [Required]
        public DateTime ngaySinh { get; set; }
        public DateTime ngayVaoLam { get; set; }

        [Required]
        public string? canCuocConDan { get; set; }
        public virtual TaiKhoanEntity? TaiKhoan { get; set; }
        public virtual LoaiNhanVienEntity? LoaiNhanVien { get; set; }

    }
}
