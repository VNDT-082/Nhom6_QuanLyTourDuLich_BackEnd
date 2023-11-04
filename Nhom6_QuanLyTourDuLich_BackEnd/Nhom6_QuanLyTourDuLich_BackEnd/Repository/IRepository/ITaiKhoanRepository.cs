using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ITaiKhoanRepository
    {
        public Task<List<TaiKhoanEntity>> GetAllAsync();
        public Task<List<TaiKhoanEntity>> GetListByTrangThai(bool trangThai);
        public Task<TaiKhoanEntity> GetOneByIdAsync(string Id);
        public Task<TaiKhoanEntity> GetOneByEmailAsync(string email);
        public Task<TaiKhoanEntity> LoginAsync(string soDienThoaiOrEmail);
        public Task<TaiKhoanEntity> GetLastAsync();
        public Task<TaiKhoanEntity> AddAsync(TaiKhoanEntity taiKhoanEntity);
        public Task<TaiKhoanEntity> UpdateAsync(TaiKhoanEntity taiKhoanEntity);
        public Task<TaiKhoanEntity> ChangePassword(TaiKhoanEntity taiKhoanEntity);
        public Task<bool> DeleteAsync(TaiKhoanEntity taiKhoanEntity);
    }
}
