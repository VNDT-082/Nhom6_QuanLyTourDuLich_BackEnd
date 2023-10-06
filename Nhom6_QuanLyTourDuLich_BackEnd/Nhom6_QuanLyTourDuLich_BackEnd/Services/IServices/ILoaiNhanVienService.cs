using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface ILoaiNhanVienService
    {
        public Task<List<LoaiNhanVienModel>> GetAllAsync();
        public Task<LoaiNhanVienModel> GetOneByIdAsync(string Id);
        //public Task<LoaiNhanVienModel> GetOneByTenLoaiAsync(string tenLoai);
        public Task<LoaiNhanVienModel> GetLastAsync();
        public Task<bool> AddAsync(LoaiNhanVien_repo loaiNhanVien_repo);
        public Task<bool> UpdateAsync(LoaiNhanVienModel loaiNhanVienModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
