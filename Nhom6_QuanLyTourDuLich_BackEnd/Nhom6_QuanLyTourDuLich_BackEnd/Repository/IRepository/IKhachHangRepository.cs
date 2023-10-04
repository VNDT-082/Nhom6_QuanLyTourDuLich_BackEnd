using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface IKhachHangRepository
    {
        public Task<List<KhachHangEntity>> GetAllAsync();
        public Task<List<KhachHangEntity>> GetAllTheoGioiTinhAsync(bool gioiTinh);
        public Task<KhachHangEntity> GetOneByIdAsync(string Id);
        public Task<KhachHangEntity> GetOneByTaiKhoanIdAsync(string maTaiKhoan);
        public Task<KhachHangEntity> GetLastAsync();
        public Task AddAsync(KhachHangEntity khachHangEntity);
        public Task UpdateAsync(KhachHangEntity khachHangEntity);
        public Task DeleteAsync(KhachHangEntity khachHangEntity);
    }
}
