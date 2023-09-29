using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("LoaiTaiKhoan")]
    public class LoaiTaiKhoanEntity:Entity
    {
        [Required]
        public string tenLoai { get; set; }
        public virtual ICollection<TaiKhoanEntity>? TaiKhoans { get; set; }
    }
}
