using Nhom6_QuanLyTourDuLich_BackEnd.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class TraLoiHoiDapModel
    {
        public TraLoiHoiDapModel()
        {

            IdTraLoiHoiDap = "TLHD" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            ngayTraLoi = DateTime.Now;
        }
        public string IdTraLoiHoiDap { get; set; }
        public string IdHoiDap { get; set; }
        public string IdKhachHang { get; set; }
        public DateTime ngayTraLoi { get; set; }
        public string noiDung { get; set; }
        //public virtual HoiDapModel? HoiDap { get; set; }
        public virtual KhachHangModel? KhachHang { get; set; }

    }
}
