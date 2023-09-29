using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("Huyen")]
    public class HuyenEntity:Entity
    {
        [Required]
        public string tenHuyen { get; set; }

        [ForeignKey("Tinh")]
        public string maTinh { get; set; }

        public virtual TinhEntity? Tinh { get; set; }
        public virtual ICollection<XaEntity>? Xas { get; set; }
    }
}
