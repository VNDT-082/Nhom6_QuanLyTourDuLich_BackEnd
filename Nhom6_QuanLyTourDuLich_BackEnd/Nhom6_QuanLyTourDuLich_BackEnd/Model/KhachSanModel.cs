using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class KhachSanModel
    {
        public string Id { get; set; }
        public string tenKhachSan { get; set; }
        public string hangSao { get; set; }
        public string diaChi { get; set; }
        public string id_Xa { get; set; }
        public string soDienThoai { get; set; }
        public KhachSanModel() { }

        public KhachSanModel(string id, string tenKhachSan, string hangSao, string diaChi, string id_Xa, string soDienThoai)
        {
            Id = id;
            this.tenKhachSan = tenKhachSan;
            this.hangSao = hangSao;
            this.diaChi = diaChi;
            this.id_Xa = id_Xa;
            this.soDienThoai = soDienThoai;
        }
    }
}
