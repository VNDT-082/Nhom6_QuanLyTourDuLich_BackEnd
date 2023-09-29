namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class LoaiTour_repo
    {
        public string tenLoai { get; set; }
        public LoaiTour_repo() { }
        public LoaiTour_repo(string tenLoai)
        { 
            this.tenLoai = tenLoai;
        }
    }
}
