using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("Xa")]
    public class XaEntity:Entity
    {
        [Required]
        public string tenXa { get; set; }

        [ForeignKey("Huyen")]
        public string maHuyen { get; set; }
        public virtual HuyenEntity? Huyen { get; set; }
    }
}
