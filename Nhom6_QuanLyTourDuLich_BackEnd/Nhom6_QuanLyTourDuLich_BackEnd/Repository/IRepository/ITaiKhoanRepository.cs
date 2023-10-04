using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Repository.IRepository
{
    public interface ITaiKhoanRepository
    {
        public Task<List<TaiKhoanEntity>> GetAllAsync();
        public Task<List<TaiKhoanEntity>> GetListByTrangThai(bool trangThai);
        public Task<TaiKhoanEntity> GetOneByIdAsync(string Id);
        public Task<TaiKhoanEntity> LoginAsync(string soDienThoaiOrEmail);
        public Task<TaiKhoanEntity> GetLastAsync();
        public Task AddAsync(TaiKhoanEntity taiKhoanEntity);
        public Task UpdateAsync(TaiKhoanEntity taiKhoanEntity);
        public Task DeleteAsync(TaiKhoanEntity taiKhoanEntity);
    }
}
