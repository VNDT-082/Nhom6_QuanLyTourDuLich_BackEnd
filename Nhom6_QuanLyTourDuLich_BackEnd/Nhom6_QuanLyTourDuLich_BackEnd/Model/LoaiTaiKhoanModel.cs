namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class LoaiTaiKhoanModel
    {
        public string Id { get; set; }
        public string tenLoai { get; set; }
        public LoaiTaiKhoanModel() { }

        public LoaiTaiKhoanModel(string Id, string tenLoai)
        {
            this.Id = Id;
            this.tenLoai = tenLoai;
        }
    }
}
