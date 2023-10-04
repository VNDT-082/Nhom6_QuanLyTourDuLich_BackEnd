using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("ThanhVien")]
    public class ThanhVienEntity : Entity
    {
        [Required]
        public string hoTen { get; set; }
        public bool gioiTinh { get; set; }

        public string? canCuocConDan { get; set; }
        public DateTime ngaySinh { get; set; }

        [ForeignKey("DatTour")]
        public string maDatTour { get; set; }
        public virtual DatTourEntity DatTour { get; set; }
    }
}
