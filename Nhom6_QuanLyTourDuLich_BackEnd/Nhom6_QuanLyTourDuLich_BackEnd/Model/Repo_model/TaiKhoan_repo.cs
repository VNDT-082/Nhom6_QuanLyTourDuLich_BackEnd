namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class TaiKhoan_repo
    {
        public string maLoai { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public string matKhau { get; set; }
        public bool trangThai { get; set; }
        public DateTime? ngayLap { get; set; }

        public TaiKhoan_repo() { }
        public TaiKhoan_repo( string maLoai, string soDienThoai, string email, string matKhau, bool trangThai, DateTime? ngayLap)
        {
            this.maLoai = maLoai;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.matKhau = matKhau;
            this.trangThai = trangThai;
            this.ngayLap = ngayLap;
        }

    }
}
