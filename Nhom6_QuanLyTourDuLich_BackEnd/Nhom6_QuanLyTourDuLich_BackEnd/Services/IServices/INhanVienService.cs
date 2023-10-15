using Nhom6_QuanLyTourDuLich_BackEnd.Model;
using Nhom6_QuanLyTourDuLich_BackEnd.Model.Repo_model;

namespace Nhom6_QuanLyTourDuLich_BackEnd.Services.IServices
{
    public interface INhanVienService
    {
        public Task<List<NhanVienModel>> GetAllAsync();
        public Task<List<NhanVienModel>> GetListByLoaiNhanVienIdAsync(string maLoaiNhanVien);
        public Task<NhanVienModel> GetOneByIDAsync(string Id);
        public Task<NhanVienModel> GetOneByCCCDAsync(string canCuocConDan);
        public Task<NhanVienModel> GetLastAsync();
        public Task<NhanVienModel> AddAsync(NhanVien_repo nhaVien_repo);
        public Task<NhanVienModel> UpdateAsync(NhanVienModel nhanVienModel);
        public Task<bool> DeleteAsync(string ID);
    }
}
