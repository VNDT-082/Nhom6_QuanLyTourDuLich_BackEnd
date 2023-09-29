using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("Tinh")]
    public class TinhEntity:Entity
    {
        [Required]
        public string tenTinh { get; set; }
        public virtual ICollection<HuyenEntity> Huyens { get; set; }
    }
}
