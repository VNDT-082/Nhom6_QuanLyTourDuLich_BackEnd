using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class XaModel
    {
        public string Id { get; set; }
        public string tenXa { get; set; }
        public string maHuyen { get; set; }
        public XaModel() { }
        public XaModel(string Id,string tenXa, string maHuyen)
        {
            this.Id = Id;
            this.tenXa = tenXa;
            this.maHuyen = maHuyen;
        }
    }
}
