namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class KhachSan_repo
    {
        public string tenKhachSan { get; set; }
        public string hangSao { get; set; }
        public string diaChi { get; set; }
        public string id_Xa { get; set; }
        public string soDienThoai { get; set; }
        public KhachSan_repo() { }

        public KhachSan_repo(string tenKhachSan, string hangSao, string diaChi, string id_Xa, string soDienThoai)
        {
            this.tenKhachSan = tenKhachSan;
            this.hangSao = hangSao;
            this.diaChi = diaChi;
            this.id_Xa = id_Xa;
            this.soDienThoai = soDienThoai;
        }
    }
}
