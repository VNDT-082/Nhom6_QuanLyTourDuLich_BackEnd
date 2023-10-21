using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("KhachHang")]
    public class KhachHangEntity
    {
        public KhachHangEntity()
        {

            IdKhachHang = "KH" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdKhachHang { get; set; }
        [Required]
        public string hoTen { get; set; }
        [Required]
        public bool gioiTinh { get; set; }

        public string? diaChi { get; set; }

        public string email { get; set; }
        public DateTime? ngaySinh { get; set; }
        
        [Required]
        public string soDienThoai { get; set; }

        [ForeignKey("TaiKhoan")]
        public string? maTaiKhoan { get; set; }
        public virtual TaiKhoanEntity? TaiKhoan { get; set; }
        public virtual ICollection<DatTourEntity>? Tours { get; set; }
        public virtual ICollection<TraLoiHoiDapEntity>? TraLoiHoiDaps { get; set; }
        public virtual ICollection<NhanXetEntity>? NhanXets { get; set; }
        public virtual ICollection<HoiDapEntity> HoiDaps { get; set; }

    }
}
