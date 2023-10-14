namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class ThanhVien_repo
    {
        public string hoTen { get; set; }
        public bool gioiTinh { get; set; }

        public string? canCuocConDan { get; set; }
        public DateTime ngaySinh { get; set; }
        public string? maDatTour { get; set; }

        public ThanhVien_repo() { }
        public ThanhVien_repo(string hoTen, bool gioiTinh, string? canCuocConDan, DateTime ngaySinh, string? maDatTour)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.canCuocConDan = canCuocConDan;
            this.ngaySinh = ngaySinh;
            this.maDatTour = maDatTour;
        }
    }
}
