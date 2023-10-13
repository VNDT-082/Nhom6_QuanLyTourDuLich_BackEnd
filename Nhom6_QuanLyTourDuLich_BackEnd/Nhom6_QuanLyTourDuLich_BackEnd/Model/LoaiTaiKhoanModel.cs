namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class LoaiTaiKhoanModel
    {
        public string IdLoaiTaiKhoan { get; set; }
        public string tenLoai { get; set; }
        public LoaiTaiKhoanModel() { }

        public LoaiTaiKhoanModel(string IdLoaiTaiKhoan, string tenLoai)
        {
            this.IdLoaiTaiKhoan = IdLoaiTaiKhoan;
            this.tenLoai = tenLoai;
        }
    }
}
