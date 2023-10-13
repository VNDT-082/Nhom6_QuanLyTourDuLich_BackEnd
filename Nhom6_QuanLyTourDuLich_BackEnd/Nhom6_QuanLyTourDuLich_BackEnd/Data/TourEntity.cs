using Nhom6_QuanLyTourDuLich_BackEnd.Data.EntityInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Data
{
    //public enum LoaiPhuongTien
    //{
    //    [EnumMember(Value = "Di chuyển bằng ôtô")]
    //    Oto,
    //    [EnumMember(Value = "Di chuyển bằng máy bay")]
    //    MayBay
        
    //}


    [Table("Tour")]
    public class TourEntity
    {
        public TourEntity()
        {

            IdTour = "Tour" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        [Key]
        public string IdTour { get; set; }
        [Required]
        public string tenTour { get; set; }
        public string? moTa { get; set; }
        public string anhBia { get; set; }

        [Required]
        public double chiPhi { get; set; }
        public DateTime ngayLap { get; set; }

        [ForeignKey("NhanVien")]
        public string? nguoiLap { get; set; }

        [ForeignKey("LoaiTour")]
        public string maLoaiTour { get; set; }

        [ForeignKey("ChuyenBay")]
        public string? maChuyenBay { get; set; }

        [ForeignKey("KhachSan")]
        public string? maKhachSan { get; set; }
        public string? phuongTienDiChuyen { get; set; }
        public bool? trangThai { get; set; }
        public virtual ChuyenBayEntity? ChuyenBay { get; set; }
        public virtual LoaiTourEntity? LoaiTour { get; set; }
        public virtual NhanVienEntity? NhanVien { get; set; }
        public virtual KhachSanEntity? KhachSan { get; set; }
        public virtual ICollection<DanhMucHinhEntity>? DanhMucHinhs { get; set; }
    }
}
