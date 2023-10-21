using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("TraLoiHoiDap")]
    public class TraLoiHoiDapEntity
    {
        public TraLoiHoiDapEntity()
        {

            IdTraLoiHoiDap = "TLHD" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            ngayTraLoi = DateTime.Now;
        }
        [Key]
        public string IdTraLoiHoiDap { get; set; }
        [ForeignKey("HoiDap")]
        public string IdHoiDap { get; set; }
        [ForeignKey("KhachHang")]
        public string IdKhachHang { get; set; }
        public DateTime ngayTraLoi { get; set; }
        public string noiDung{get;set;}
        public virtual HoiDapEntity? HoiDap { get; set; }
        public virtual KhachHangEntity? KhachHang { get; set;}

    }
}
