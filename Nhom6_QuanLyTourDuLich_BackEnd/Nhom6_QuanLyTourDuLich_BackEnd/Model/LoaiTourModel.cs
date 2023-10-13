namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class LoaiTourModel
    {
        public string IdLoaiTour { get; set; }
        public string tenLoai { get; set; }
        public LoaiTourModel() { }
        public LoaiTourModel(string IdLoaiTour, string tenLoai)
        {
            this.IdLoaiTour = IdLoaiTour;
            this.tenLoai = tenLoai;
        }
    }
}
