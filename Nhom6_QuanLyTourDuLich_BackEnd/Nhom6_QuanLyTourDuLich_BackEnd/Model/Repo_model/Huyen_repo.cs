namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class Huyen_repo
    {
        public string tenHuyen { get; set; }
        public string maTinh { get; set; }
        public Huyen_repo(string tenHuyen, string maTinh)
        {
            this.tenHuyen = tenHuyen;
            this.maTinh = maTinh;
        }
        public Huyen_repo() { }
    }
}
