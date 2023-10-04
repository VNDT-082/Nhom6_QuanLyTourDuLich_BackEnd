namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class Xa_repo
    {
        public string tenXa { get; set; }
        public string maHuyen { get; set; }
        public Xa_repo() { }
        public Xa_repo(string tenXa, string maHuyen)
        {
            this.tenXa = tenXa;
            this.maHuyen = maHuyen;
        }
    }
}
