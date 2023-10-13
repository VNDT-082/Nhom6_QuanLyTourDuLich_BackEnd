using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("LoaiTaiKhoan")]
    public class LoaiTaiKhoanEntity
    {
        public LoaiTaiKhoanEntity()
        {

            IdLoaiTaiKhoan = "LTK" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdLoaiTaiKhoan { get; set; }
        [Required]
        public string tenLoai { get; set; }
        public virtual ICollection<TaiKhoanEntity>? TaiKhoans { get; set; }
    }
}
