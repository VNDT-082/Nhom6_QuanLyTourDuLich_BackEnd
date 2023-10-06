using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface IKhachHangService
    {
        public Task<List<KhachHangModel>> GetAllAsync();
        public Task<List<KhachHangModel>> GetAllTheoGioiTinhAsync(bool gioiTinh);
        public Task<KhachHangModel> GetOneByIdAsync(string Id);
        public Task<KhachHangModel> GetOneByTaiKhoanIdAsync(string maTaiKhoan);
        public Task<KhachHangModel> GetLastAsync();
        public Task<bool> AddAsync(KhachHang_repo khachHang_repo);
        public Task<bool> UpdateAsync(KhachHangModel khachHangModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
