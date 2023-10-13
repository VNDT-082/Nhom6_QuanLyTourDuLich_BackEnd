using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class DanhMucHinhModel
    {
        public string IdDanhMucHinh { get; set; }
        public string fileName { get; set; }
        public string maTour { get; set; }

        public DanhMucHinhModel() { }
        public DanhMucHinhModel(string IdDanhMucHinh, string fileName, string maTour)
        {
            this.IdDanhMucHinh = IdDanhMucHinh;
            this.fileName = fileName;
            this.maTour = maTour;
        }
    }
}
