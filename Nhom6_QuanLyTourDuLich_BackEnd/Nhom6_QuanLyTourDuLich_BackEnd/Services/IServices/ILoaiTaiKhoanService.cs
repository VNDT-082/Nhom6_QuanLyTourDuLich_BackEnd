using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ILoaiTaiKhoanService
    {
        public Task<List<LoaiTaiKhoanModel>> GetAllAsync();
        public Task<LoaiTaiKhoanModel> GetOneByIdAsync(string Id);
        //public Task<LoaiTaiKhoanModel> GetOneByTenLoaiAsync(string tenLoai);
        public Task<LoaiTaiKhoanModel> GetLastAsync();
        public Task<bool> AddAsync(LoaiTaiKhoan_repo loaiTaiKhoan_repo);
        public Task<bool> UpdateAsync(LoaiTaiKhoanModel loaiTaiKhoanModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
