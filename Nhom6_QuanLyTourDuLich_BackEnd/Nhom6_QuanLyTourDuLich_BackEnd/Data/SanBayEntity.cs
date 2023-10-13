using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("SanBay")]
    public class SanBayEntity
    {
        public SanBayEntity()
        {

            IdSanBay = "SB" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdSanBay { get; set; }
        [Required]
        public string tenSanBay { get; set; }
    }
}
