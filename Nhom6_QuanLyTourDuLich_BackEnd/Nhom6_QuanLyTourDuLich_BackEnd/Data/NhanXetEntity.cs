using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("NhanXet")]
    public class NhanXetEntity
    {
       
        public NhanXetEntity()
        {

            IdNhanXet = "CM" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            ngayDang = DateTime.Now;
        }
        [Key]
        public string IdNhanXet { get; set; }
        [ForeignKey("KhachHang")]
        public string IdNguoiDung { get; set; }

        [ForeignKey("Tour")]
        public string IdTour { get; set; }
        public DateTime ngayDang { get; set; }

        [Required]
        public string noiDung { get; set; }

        [Required]
        public int danhGia { get; set; }
        public virtual KhachHangEntity? KhachHang { get; set; }
        public virtual TourEntity? Tour { get; set; }
    }
}
