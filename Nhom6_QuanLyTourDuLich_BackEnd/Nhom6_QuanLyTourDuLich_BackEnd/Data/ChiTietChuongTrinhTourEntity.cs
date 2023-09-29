using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    [Table("ChiTietChuongTrinhTour")]
    public class ChiTietChuongTrinhTourEntity : Entity
    {
        [ForeignKey("Tour")]
        public string maTour { get; set; }
        public DateTime thoiGianBatDau { get; set; }
        public DateTime thoiGianKetThuc { get; set; }
        public string diemKhoiHanh { get; set; }
        public string diemDen { get; set; }

        [Required]
        public string tieuDe { get; set; }
        public string moTa { get; set; }
        public string hinhAnh { get; set; }
        public string maKhachSan { get; set; }
        public string phuongTien { get; set; }
        public virtual TourEntity Tour { get; set; }
    }
}
