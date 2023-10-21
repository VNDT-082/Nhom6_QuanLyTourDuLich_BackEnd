using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Azure.Core.Pipeline;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("HoiDap")]
    public class HoiDapEntity
    {
        public HoiDapEntity()
        {

            IdHoiDap = "HD" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            ngayDang = DateTime.Now;
        }
        [Key]
        public string IdHoiDap { get; set; }

        [ForeignKey("KhachHang")]
        public string IdNguoiDung { get; set; }

        [ForeignKey("Tour")]
        public string IdTour { get; set; }
        public DateTime ngayDang { get; set; }
        public string noiDung { get; set; }
        public virtual KhachHangEntity? KhachHang { get; set; }
        public virtual TourEntity? Tour { get; set; }
        public virtual ICollection<TraLoiHoiDapEntity>? danhSachCauTraLoi { get; set; }
    }
}
