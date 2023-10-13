namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class LoaiNhanVienModel
    {
        public string IdLoaiNhanVien { get; set; }
        public string tenLoai { get; set; }
        public LoaiNhanVienModel() { }

        public LoaiNhanVienModel(string IdLoaiNhanVien, string tenLoai)
        {
            this.IdLoaiNhanVien = IdLoaiNhanVien;
            this.tenLoai = tenLoai;
        }
    }
}
