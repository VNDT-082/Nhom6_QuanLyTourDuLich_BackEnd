namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class LoaiNhanVien_repo
    {
        public string tenLoai { get; set; }
        public LoaiNhanVien_repo() { }

        public LoaiNhanVien_repo(string tenLoai)
        {
            this.tenLoai = tenLoai;
        }
    }
}
