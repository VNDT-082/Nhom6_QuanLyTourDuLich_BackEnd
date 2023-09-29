namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class LoaiTourModel
    {
        public string Id { get; set; }
        public string tenLoai { get; set; }
        public LoaiTourModel() { }
        public LoaiTourModel(string Id, string tenLoai)
        {
            this.Id = Id;
            this.tenLoai = tenLoai;
        }
    }
}
