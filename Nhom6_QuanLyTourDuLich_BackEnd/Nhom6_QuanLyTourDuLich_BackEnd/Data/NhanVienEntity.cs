using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("NhanVien")]
    public class NhanVienEntity
    {
        public NhanVienEntity()
        {

            IdNhanVien = "NV" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdNhanVien { get; set; }
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
        public string diaChi { get; set; }
        public bool trangThai { get; set; }
        [Required]
        public string? canCuocConDan { get; set; }
        public virtual TaiKhoanEntity? TaiKhoan { get; set; }
        public virtual LoaiNhanVienEntity? LoaiNhanVien { get; set; }

    }
}
