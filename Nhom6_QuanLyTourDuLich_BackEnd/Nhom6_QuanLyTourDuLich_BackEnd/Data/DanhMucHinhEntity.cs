using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("DanhMucHinh")]
    public class DanhMucHinhEntity : Entity
    {
        [Required]
        public string fileName { get; set; }

        [ForeignKey("Tour")]
        [Required]
        public string maTour { get; set; }
        public virtual TourEntity Tour { get; set; }
    }
}
