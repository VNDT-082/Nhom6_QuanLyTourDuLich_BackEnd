using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("TaiKhoan")]
    public class TaiKhoanEntity
    {
        public TaiKhoanEntity()
        {

            IdTaiKhoan = "TK" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdTaiKhoan { get; set; }

        [ForeignKey("LoaiTaiKhoan")]
        public string maLoai { get; set; }

        [Required]
        public string soDienThoai { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string matKhau { get; set; }
        public bool trangThai { get; set; }
        public DateTime? ngayLap { get; set; }
        public virtual LoaiTaiKhoanEntity? LoaiTaiKhoan { get; set; }
    }
}
