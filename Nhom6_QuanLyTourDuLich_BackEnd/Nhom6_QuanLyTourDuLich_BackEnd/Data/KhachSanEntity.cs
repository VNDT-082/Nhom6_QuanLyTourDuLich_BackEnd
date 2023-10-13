using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("KhachSan")]
    public class KhachSanEntity
    {
        public KhachSanEntity()
        {

            IdKhachSan = "KS" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdKhachSan { get; set; }
        [Required]
        public string tenKhachSan { get; set; }
        public string hangSao { get; set; }

        [Required]
        public string diaChi { get; set; }
        public string? soDienThoai { get; set;}


    }
}
