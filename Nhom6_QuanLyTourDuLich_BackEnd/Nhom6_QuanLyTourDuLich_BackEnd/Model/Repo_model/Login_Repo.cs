namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class Login_Repo
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public Login_Repo() { }
        public Login_Repo(string tenDangNhap, string matKhau)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }
    }
}
