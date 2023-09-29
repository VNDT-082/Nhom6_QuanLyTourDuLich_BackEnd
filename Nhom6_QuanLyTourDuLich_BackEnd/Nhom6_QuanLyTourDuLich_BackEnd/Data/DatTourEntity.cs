using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("DatTour")]
    public class DatTourEntity:Entity
    {
        [ForeignKey("KhachHang")]
        [Required]
        public string maKhach { get; set; }
        [ForeignKey("HuongDanVien")]
        public string? maHuongDanVien { get; set; }
        [ForeignKey("Tour")]
        [Required]
        public string maTour { get; set; }
        public int soLuong { get; set; }
        public DateTime ngayDat { get; set;}
        public bool trangThai { get; set; }

        public virtual TourEntity Tour { get; set; }
        public virtual NhanVienEntity? HuongDanVien { get; set; }
        public virtual KhachHangEntity KhachHang { get; set; }
        public virtual ICollection<ThanhVienEntity>? ThanhViens { get; set; }
    }
}
