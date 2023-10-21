using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class HoiDapModel
    {
        public HoiDapModel()
        {

            IdHoiDap = "HD" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            ngayDang = DateTime.Now;
        }
        public string IdHoiDap { get; set; }
        public string IdNguoiDung { get; set; }
        public string IdTour { get; set; }
        public DateTime ngayDang { get; set; }
        public string noiDung { get; set; }
        public virtual KhachHangEntity? KhachHang { get; set; }
        public virtual TourEntity? Tour { get; set; }
        public virtual ICollection<TraLoiHoiDapEntity>? danhSachCauTraLoi { get; set; }
    }
}
