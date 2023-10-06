using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Data;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ITaiKhoanService
    {
        public Task<List<TaiKhoanModel>> GetAllAsync();
        public Task<List<TaiKhoanModel>> GetListByTrangThai(bool trangThai);
        public Task<TaiKhoanModel> GetOneByIdAsync(string Id);
        public Task<TaiKhoanModel> LoginAsync(string soDienThoaiOrEmail);
        public Task<TaiKhoanModel> GetLastAsync();
        public Task<bool> AddAsync(TaiKhoan_repo taiKhoan_repo);
        public Task<bool> UpdateAsync(TaiKhoanModel taiKhoanModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
