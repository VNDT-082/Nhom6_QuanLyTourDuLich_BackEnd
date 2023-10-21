using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class NhanXet_repo
    {
        public string IdNguoiDung { get; set; }

        public string IdTour { get; set; }
        //public DateTime ngayDang { get; set; }

        public string noiDung { get; set; }
        public int danhGia { get; set; }
        public NhanXet_repo() { }
    }
}
