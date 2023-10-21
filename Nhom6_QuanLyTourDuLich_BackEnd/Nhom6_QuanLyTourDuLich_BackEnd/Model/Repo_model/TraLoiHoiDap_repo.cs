using System.ComponentModel.DataAnnotations.Schema;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class TraLoiHoiDap_repo
    {
        public string IdHoiDap { get; set; }
        public string IdKhachHang { get; set; }
        public string noiDung { get; set; }
        public TraLoiHoiDap_repo() { }  
    }
}
