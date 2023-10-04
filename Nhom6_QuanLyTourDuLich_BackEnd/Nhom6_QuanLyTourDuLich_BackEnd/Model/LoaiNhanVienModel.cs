namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class LoaiNhanVienModel
    {
        public string Id { get; set; }
        public string tenLoai { get; set; }
        public LoaiNhanVienModel() { }

        public LoaiNhanVienModel(string id, string tenLoai)
        {
            Id = id;
            this.tenLoai = tenLoai;
        }
    }
}
