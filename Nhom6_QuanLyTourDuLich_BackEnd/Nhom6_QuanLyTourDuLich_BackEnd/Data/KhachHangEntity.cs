using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("KhachHang")]
    public class KhachHangEntity:Entity
    {
        [Required]
        public string hoTen { get; set; }
        [Required]
        public bool gioiTinh { get; set; }

        public string? diaChi { get; set; }

        [ForeignKey("Xa")]
        public string? id_Xa { get; set; }
        public string email { get; set; }
        public DateTime? ngaySinh { get; set; }
        
        [Required]
        public string soDienThoai { get; set; }

        [ForeignKey("TaiKhoan")]
        public string? maTaiKhoan { get; set; }
        public virtual XaEntity? Xa { get; set; }
        public virtual TaiKhoanEntity? TaiKhoan { get; set; }
        public virtual ICollection<DatTourEntity>? Tours { get; set; }
    }
}
