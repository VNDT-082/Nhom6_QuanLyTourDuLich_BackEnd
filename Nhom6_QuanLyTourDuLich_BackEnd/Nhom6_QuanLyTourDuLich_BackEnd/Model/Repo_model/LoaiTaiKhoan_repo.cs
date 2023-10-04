namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class LoaiTaiKhoan_repo
    {
        public string tenLoai { get; set; }
        public LoaiTaiKhoan_repo() { }

        public LoaiTaiKhoan_repo(string tenLoai)
        {
            this.tenLoai = tenLoai;
        }
    }
}
