using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class HuyenModel
    {
        public string Id { get; set; }
        public string tenHuyen { get; set; }
        public string maTinh { get; set; }
        public HuyenModel(string id, string tenHuyen, string maTinh)
        {
            Id = id;
            this.tenHuyen = tenHuyen;
            this.maTinh = maTinh;
        }
        public HuyenModel() { }
    }
}
