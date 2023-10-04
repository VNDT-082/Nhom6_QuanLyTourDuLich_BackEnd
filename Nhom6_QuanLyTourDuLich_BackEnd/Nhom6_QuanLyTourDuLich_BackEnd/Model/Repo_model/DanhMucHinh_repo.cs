namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class DanhMucHinh_repo
    {
        public string fileName { get; set; }
        public string maTour { get; set; }

        public DanhMucHinh_repo() { }
        public DanhMucHinh_repo( string fileName, string maTour)
        {
            this.fileName = fileName;
            this.maTour = maTour;
        }
    }
}
