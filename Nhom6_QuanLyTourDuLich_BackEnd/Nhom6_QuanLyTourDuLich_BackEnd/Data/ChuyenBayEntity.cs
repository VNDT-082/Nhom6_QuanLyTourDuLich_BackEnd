using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("ChuyenBay")]
    public class ChuyenBayEntity
    {
        public ChuyenBayEntity()
        {

            IdChuyenBay= "CB" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdChuyenBay { get; set; }
        public string hangBay { get; set; }
        public DateTime gioKhoiHanh { get; set; }
        [ForeignKey("SanBayDi")]
        public string? noiKhoiHanh { get; set; }
        public DateTime gioDen { get; set; }

        [ForeignKey("SanBayDen")]
        public string? noiDen { get; set; }
        public bool khuHoi { get; set; }
        public string mayBay { get; set; }
        public bool trangThai { get; set; }


        [ForeignKey("ChuyenBay")]
        public string? maChuyenVe { get; set; }
        public virtual ChuyenBayEntity? ChuyenBay { get; set; }
        public virtual SanBayEntity? SanBayDi { get; set; }
        public virtual SanBayEntity? SanBayDen { get; set; }
    }
}
