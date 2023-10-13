using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class KhachSanModel
    {
        public string IdKhachSan { get; set; }
        public string tenKhachSan { get; set; }
        public string hangSao { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public KhachSanModel() { }

        public KhachSanModel(string IdKhachSan, string tenKhachSan, string hangSao, string diaChi, string soDienThoai)
        {
            IdKhachSan = IdKhachSan;
            this.tenKhachSan = tenKhachSan;
            this.hangSao = hangSao;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
        }
    }
}
