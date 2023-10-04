using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model
{
    public class DanhMucHinhModel
    {
        public string Id { get; set; }
        public string fileName { get; set; }
        public string maTour { get; set; }

        public DanhMucHinhModel() { }
        public DanhMucHinhModel(string id, string fileName, string maTour)
        {
            Id = id;
            this.fileName = fileName;
            this.maTour = maTour;
        }
    }
}
