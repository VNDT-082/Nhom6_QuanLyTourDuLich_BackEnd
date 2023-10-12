namespace Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model
{
    public class NhanVien_repo
    {
        public string? maTaiKhoan { get; set; }
        public string maLoaiNhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public bool gioiTinh { get; set; }
        public string soDienThoai { get; set; }
        public DateTime ngaySinh { get; set; }
        public DateTime ngayVaoLam { get; set; }
        public string? canCuocConDan { get; set; }
        public string diaChi { get; set; }
        public NhanVien_repo() { }

        public NhanVien_repo( string? maTaiKhoan, string maLoaiNhanVien, string tenNhanVien, bool gioiTinh,
            string soDienThoai, DateTime ngaySinh, DateTime ngayVaoLam, string? canCuocConDan, string diaChi)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.maLoaiNhanVien = maLoaiNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
            this.ngayVaoLam = ngayVaoLam;
            this.canCuocConDan = canCuocConDan;
            this.diaChi = diaChi;
        }
    }
}
